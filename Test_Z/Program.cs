using Microsoft.Extensions.DependencyInjection;
using System;
using Test_Z.Factories;
using Test_Z.Integration;

namespace Test_Z
{
    class Program
    {
        static ServiceProvider _serviceProvider;
         static void Main(string[] args)
        {
            Console.WriteLine("Enter Price");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter client type");
            int clientType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter years");
            int years = Convert.ToInt32(Console.ReadLine());


            _serviceProvider = new ServiceCollection()
           .AddSingleton<IThirdPartyIntegration, ThirdPartyIntegration>()
           .BuildServiceProvider();

            decimal result = DiscountCalculator(price, clientType, years);


            Console.WriteLine($"Discounted Price: {result} ");
            Console.ReadKey();
        }

        static decimal DiscountCalculator(decimal price, int clientType, int years)
        {
            try
            {

                //Factory Pattern
                IThirdPartyIntegration thirdPartyIntegration = _serviceProvider.GetService<IThirdPartyIntegration>();
                ClientFactory clientFactory = new ClientFactory(thirdPartyIntegration);
                return clientFactory.GetPrice(price, clientType, years);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exeception in calculating price Price: {ex.Message} ");
            }
            return 0m;
        }
    }
}
