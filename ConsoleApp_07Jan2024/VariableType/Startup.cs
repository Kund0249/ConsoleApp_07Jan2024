using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.VariableType
{
    class Startup
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "TV",
                ProductPrice = 32000
            };

            //product.ProductId = 2;
            //product.DiscountPercentage = 20;
            //Console.WriteLine(product.DiscountPercentage);
        }
    }
}
