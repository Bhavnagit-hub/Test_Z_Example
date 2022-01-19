using Test_Z.Integration;
using Test_Z.Clients;

namespace Test_Z.Factories
{
    public class ClientFactory 
    {
        private IThirdPartyIntegration _intg;

        //dependency injected
        public ClientFactory(IThirdPartyIntegration integration)
        {
            _intg = integration;
        }
        public decimal GetPrice(decimal price, int clientType, int years)
        {
            IClientFactory clientFactory = null;
            decimal discount = _intg.GetDiscount(years);
            switch (clientType)
            {//Factories for losely coupled
                case 1:
                    clientFactory = new GoldFactory(price,discount);
                    break;
                case 2:
                    clientFactory = new PlatinumClientFactory(price, discount);
                    break;
                case 3:
                    clientFactory = new SilverClientFactory(price,discount);
                    break;
                default:
                    break;
            }

            IClient client = clientFactory?.GetClient();

            if(client!=null)
            {
                return client.GetPrice();
            }

            throw new System.Exception("Client is not registered");
        }
    }
}
