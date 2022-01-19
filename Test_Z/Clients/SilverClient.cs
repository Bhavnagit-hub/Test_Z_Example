using System;
using System.Collections.Generic;
using System.Text;
using Test_Z.Integration;

namespace Test_Z.Clients
{
    public class SilverClient : IClient
    {
        private decimal _price { get; set; }

        private decimal _discount { get; set; }

        public SilverClient(decimal price, decimal discount)
        {
            _price = price;
            _discount = discount;
        }

        public decimal GetPrice()
        {
            return _price - 0.5m * _price - _discount * (_price - 0.5m * _price);
        }
    }
}
