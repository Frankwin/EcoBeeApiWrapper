using EcoBeeApiWrapper.Enums;
using Newtonsoft.Json;

namespace EcoBeeApiWrapper.Models
{
    public class PinCodeResponse
    {
        public string EcoBeePin { get; set; }
        public string Code { get; set; }
        public Scope Scope { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        public int Interval { get; set; }
    }
}
