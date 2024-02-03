using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ControlStatements
{
    class ForLoopDemo
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Hello");
            //}

            //11 => 1 [2 3 4 5 6 7 8 9 10] 11

            Console.Write("Enter N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;

            for(int i = 2; i < N; i++)
            {
                if(N % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            if(IsPrime == true)
                Console.WriteLine("{0} is a prime number",N);
            else
                Console.WriteLine("{0} is not a prime number", N);


        }
    }
}
