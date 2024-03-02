using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_07Jan2024.Enumeration;
using ConsoleApp_07Jan2024.Generics_Example;

namespace ConsoleApp_07Jan2024
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notification.Notify("Employee not Added!", NotificationType.error);

            //int N1 = 10;
            //int N2 = 10;

            string N1 = "John";
            string N2 = "John";

           bool isEqual =  Comparer.Equal<int>(10, 20);

            if (isEqual)
            {
                Console.WriteLine("both values are equals");
            }
            else
            {
                Console.WriteLine("both values are not equals");
            }
        }
    }
}
