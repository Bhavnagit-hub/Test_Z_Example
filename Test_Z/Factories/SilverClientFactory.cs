using Test_Z.Integration;
using Test_Z.Clients;

namespace Test_Z.Factories
{
    public class SilverClientFactory : IClientFactory
    {

        private decimal _price { get; set; }

        private decimal _discount { get; set; }

        public SilverClientFactory(decimal price, decimal discount)
        {
            _price = price;
            _discount = discount;
        }
        public IClient GetClient()
        {
            return new SilverClient(_price, _discount);
        }
    }
}
