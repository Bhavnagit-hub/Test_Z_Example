using Test_Z.Integration;
using Test_Z.Clients;

namespace Test_Z.Factories
{
    public class PlatinumClientFactory :IClientFactory
    {
        private decimal _price { get; set; }

        private decimal _discount { get; set; }

        public PlatinumClientFactory(decimal price, decimal discount)
        {
            _price = price;
            _discount = discount;
        }
        public IClient GetClient()
        {
            return new PlatinumClient(_price, _discount);
        }
    }
}
