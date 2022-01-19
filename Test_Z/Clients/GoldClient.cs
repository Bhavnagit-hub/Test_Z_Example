using System;
using System.Collections.Generic;
using System.Text;
using Test_Z.Integration;

namespace Test_Z.Clients
{
    public class GoldClient : IClient
    {

        private decimal _price { get; set; }

        private decimal _discount { get; set; }

        public GoldClient(decimal price, decimal discount)
        {
            _price = price;
            _discount = discount;
        }

        public decimal GetPrice()
        {
            return  _price;
        }
    }
}
