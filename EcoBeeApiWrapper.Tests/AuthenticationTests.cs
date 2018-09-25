using System.Threading.Tasks;
using EcoBeeApiWrapper.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EcoBeeApiWrapper.Tests
{
    [TestClass]
    public class AuthenticationTests : TestBase
    {
        // Disabled as this test should only be run once and a manual step is needed to validate the
        // PinCode retrieved with the EcoBee Developer Console.
        [Ignore]
        [TestMethod]
        public async Task SuccessfulPinRequestTest()
        {
            var result = await EcoBeeApi.GetPinCode(Scope.SmartRead);

            Assert.IsTrue(result.EcoBeePin != null);
            Assert.IsTrue(result.Code != null);
        }

        public async Task SuccessfulAuthorizationToken()
        {
        }
    }
}
