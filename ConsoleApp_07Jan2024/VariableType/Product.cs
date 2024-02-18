using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.VariableType
{
    class Product
    {
        //Static Variable
        public static string Distributor;

        //Instance Variable
        public int ProductId = 1;
        public string ProductName;
        public uint ProductPrice;

        //constant variable
        public const byte DiscountPercentage = 10;

        //ReadOnly Variable
        public readonly string GSTNumber;

        public Product()
        {
            //
            GSTNumber = "u4y37ndjb3y2746";
        }

        //Local Variable - _productId
        public void Remove(int _productId)
        {
            //GSTNumber = "u4y37ndjb3y2746";
            Console.WriteLine(_productId);
            
            //DiscountPercentage = 20;
            //code
        }
      
    }
}
