using NUnit.Framework;
using Test_Z.Factories;
using Test_Z.Integration;

namespace Test_Z
{
    class TestClass
    {
        [TestFixture]
        public class PrimeService_IsPrimeShould
        {
            private IThirdPartyIntegration _integration;
            private ClientFactory _clientFactory;

            [SetUp]
            public void SetUp()
            {
                _integration = new ThirdPartyIntegration();
                _clientFactory = new ClientFactory(_integration);
            }

            [Test]
            public void IsPrime_InputIs1_ReturnFalse()
            {
                decimal price = _clientFactory.GetPrice(33, 3, 3);

                Assert.AreEqual(16.005, price, "should match");
            }
        }
    }
}
