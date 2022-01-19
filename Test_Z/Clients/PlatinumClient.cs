using System;
using System.Collections.Generic;
using System.Text;
using Test_Z.Integration;

namespace Test_Z.Clients
{
    public class PlatinumClient : IClient
    {
        private decimal _price { get; set; }

        private decimal _discount { get; set; }

        public PlatinumClient(decimal price, decimal discount)
        {
            _price = price;
            _discount = discount;
        }

        /// <summary>
        /// Formala can be change or calculated
        /// </summary>
        /// <returns></returns>
        public decimal GetPrice()
        {
            decimal price = _price - 0.1m * _price - _discount * (_price - 0.1m * _price);
            return price;
        }
    }
}
