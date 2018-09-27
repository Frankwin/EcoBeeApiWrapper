using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EcoBeeApiWrapper.Tests
{
    public class TestBase
    {
        protected EcoBeeApiWrapper EcoBeeApi;
        public static IConfigurationRoot Config { get; private set; }

        public string EcoBeePin { get; set; }
        public string Code { get; set; }

        [TestInitialize]
        public async Task TestClassSetup()
        {
            EcoBeeApi = new EcoBeeApiWrapper();

            Config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            await EcoBeeApi.RefreshAuthorizationToken();
        }
    }
}

