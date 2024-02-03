using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ControlStatements
{
    class WhileLoopDemo
    {
        static void Main(string[] args)
        {
            //int n = 1;
            //while (n <= 10)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}

            //int N = 1234 => 4321
            Console.Write("Enter Number : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int OriginalValue = N;

            int rev = 0;
            while(N > 0)
            {
                int rem = N % 10;
                rev = rev * 10 + rem;//4
                N = N / 10;
            }
            
            //Console.WriteLine("Reverse : " + rev);
            if(OriginalValue == rev)
                Console.WriteLine("Given number is a palindrome number");
            else
                Console.WriteLine("Given number not is a palindrome number");
        }
    }

}
