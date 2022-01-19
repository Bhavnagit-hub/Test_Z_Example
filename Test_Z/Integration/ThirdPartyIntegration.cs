using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Z.Integration
{
    public class ThirdPartyIntegration : IThirdPartyIntegration
    {

        public ThirdPartyIntegration()
        {
        }
        public decimal GetDiscount(int years)
        {
           return (years > 7) ? (decimal)7 / 100 : (decimal)years / 100;
        }
    }
}
