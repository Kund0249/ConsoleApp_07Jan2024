using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ControlStatements
{
    class IFDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Value : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            //int reminder = N1 % 2;

            //Console.WriteLine("Reminder : " + reminder);
            if(N1 == 0 || N1 < 0)
                Console.WriteLine("please enter a +ve int value");
            else if(N1 % 2 == 0)
                Console.WriteLine("{0} is Even",N1);
            else
                Console.WriteLine("{0} is Odd",N1);

            //if(N1 > 0)
            //{
            //    Console.WriteLine("Given number is +ve");
            //}
            //else if(N1 < 0)
            //    Console.WriteLine("Give number is -ve");
            //else
            //    Console.WriteLine("Given number neither +ve nor -ve");

            //if(N1 < 0)
            //Console.WriteLine("Give number is -ve");

            //Console.WriteLine("Hi");
            //Console.WriteLine("Hello");
            //int N1 = 10;
            //int N2 = 20;
            //int Sum = N1 + N2;
            //Console.WriteLine("Sum : " + Sum);

        }
    }
}
