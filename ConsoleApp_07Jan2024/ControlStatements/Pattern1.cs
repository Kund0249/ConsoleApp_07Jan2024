using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ControlStatements
{
    class Pattern1
    {
        //       *
        //      * *
        //     *   *
        //    *******
        static void Main(string[] args)
        {
            //Console.WriteLine("   *");
            //Console.WriteLine("  *@*");
            //Console.WriteLine(" *@@@*");
            //Console.WriteLine("*@@@@@*");

            Console.Write("Enter Size : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int s = size - 1;
            int p = 1;


            for (int i = 1; i <= size; i++)
            {
                for (int space = 1; space <= s; space++)
                {
                    Console.Write(" ");
                }

                for (int pattern = 1; pattern <= p; pattern++)
                {
                    if (pattern == 1 || pattern == p || i == size)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
                s--;
                p = p + 2;
            }
        }
    }
}
