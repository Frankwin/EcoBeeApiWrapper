using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EcoBeeApiWrapper.Enums;
using EcoBeeApiWrapper.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace EcoBeeApiWrapper
{
    public class EcoBeeApiWrapper
    {
        public PinCodeResponse PinCodeResponse { get; set; }
        public AuthorizationResponse AuthorizationResponse { get; set; }

        public static IConfigurationRoot Config { get; private set; }

        private readonly string apiAddress;
        private readonly string apiKey;

        public EcoBeeApiWrapper()
        {
            Config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            apiAddress = Config["api-url"];
            apiKey = Config["api-key"];
        }

        public async Task<PinCodeResponse> GetPinCode(Scope scope)
        {
            using (var httpClient = new HttpClient())
            {
                var response =
                    await httpClient.GetAsync(
                        $"{apiAddress}/authorize?response_type=ecobeePin&client_id={apiKey}&scope={scope}");
                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        throw new HttpRequestException("The provided API Key was invalid");
                    }
                    throw new HttpRequestException($"{(int)response.StatusCode} - {response.ReasonPhrase}");
                }

                var json = await response.Content.ReadAsStringAsync();
                PinCodeResponse = JsonConvert.DeserializeObject<PinCodeResponse>(json);

                var appSettingsJson = File.ReadAllText("appsettings.json");
                dynamic jsonObj = JsonConvert.DeserializeObject(appSettingsJson);
                jsonObj["ecobeePin"] = PinCodeResponse.EcoBeePin;
                jsonObj["code"] = string.Join(",", PinCodeResponse.Code);
                string output =
                    JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                Config.Reload();

                return PinCodeResponse;
            }
        }

        public async Task<AuthorizationResponse> GetAuthorizationTokenWithPin(string code)
        {
            using (var httpClient = new HttpClient())
            {
                var callData = $"{apiAddress}/token?grant_type=ecobeePin&code={code}&client_id={apiKey}";

                var response = await httpClient.PostAsync(callData, null);

                await CheckResponseStatus(response, httpClient, callData);

                var json = await response.Content.ReadAsStringAsync();

                AuthorizationResponse = JsonConvert.DeserializeObject<AuthorizationResponse>(json);

                var appSettingsJson = File.ReadAllText("appsettings.json");
                dynamic jsonObj = JsonConvert.DeserializeObject(appSettingsJson);
                jsonObj["access-token"] = AuthorizationResponse.AccessToken;
                jsonObj["refresh-token"] = AuthorizationResponse.RefreshToken;
                jsonObj["expiration-time"] = DateTime.Now.AddMinutes(AuthorizationResponse.ExpiresIn);
                string output =
                    JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                Config.Reload();

                return AuthorizationResponse;
            }
        }

        public async Task<AuthorizationResponse> RefreshAuthorizationToken()
        {
            using (var httpClient = new HttpClient())
            {
                var callData = $"{apiAddress}/token?grant_type=refresh_token&refresh_token={Config["refresh-token"]}&client_id={apiKey}";

                var response = await httpClient.PostAsync(callData, null);

                await CheckResponseStatus(response, httpClient, callData);

                var json = await response.Content.ReadAsStringAsync();

                AuthorizationResponse = JsonConvert.DeserializeObject<AuthorizationResponse>(json);

                return AuthorizationResponse;
            }
        }

        #region Private methods

        /// <summary>
        /// Check the response status of the Http Call and if we get an Unauthorized response try
        /// to Authenticate again and then retry the call
        /// </summary>
        /// <param name="response">Response to check the status for</param>
        /// <param name="httpClient">HttpClient object to use to retry the call</param>
        /// <param name="callData">Call Data to retry</param>
        /// <exception cref="HttpRequestException">Exception thrown if the request was not successfull.</exception>
        private async Task CheckResponseStatus(HttpResponseMessage response, HttpClient httpClient, string callData)
        {
            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode != HttpStatusCode.Unauthorized)
                    throw new HttpRequestException($"{(int)response.StatusCode} - {response.ReasonPhrase}");

                // Try to authenticate and retry the call if we got an Unauthorized Status Code as the token probably has expired
                await RefreshAuthorizationToken();
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"{(int)response.StatusCode} - {response.ReasonPhrase}");
                }

                await httpClient.GetAsync(callData);

                throw new HttpRequestException($"{(int)response.StatusCode} - {response.ReasonPhrase}");
            }
        }

        #endregion Private methods
    }
}
