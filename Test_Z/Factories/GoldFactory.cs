using System;
using System.Collections.Generic;
using System.Text;
using Test_Z.Integration;
using Test_Z.Clients;

namespace Test_Z.Factories
{
    public class GoldFactory : IClientFactory
    {
        private decimal _price { get; set; }

        private decimal _discount { get; set; }

        public GoldFactory(decimal price,decimal discount)
        {
            _price = price;
            _discount = discount;
        }
        public IClient GetClient()
        {
            return new GoldClient(_price,_discount);
        }
    }
}
