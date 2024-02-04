using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ArrayExample
{
    class SingleDimentionArray
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //0 1 2 3 4
            //int[] Numbers = new int[5];
            //Numbers[0] = 10;
            //Numbers[1] = 20;
            //Numbers[2] = 30;
            //Numbers[3] = 40;
            //Numbers[4] = 50;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            int[] values = new int[3];
            int sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write("N{0} : ", (i + 1));
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("--------------------------------");
            //Console.Write("Sum of [");
            for (int i = 0; i < values.Length; i++)
            {
                sum = sum + values[i];
                Console.Write(values[i]);

                if (i < values.Length - 1)
                {
                    Console.Write("  +  ");
                }
                else
                {
                    Console.Write(" = ");
                }
            }
            Console.Write(sum);
            //Console.Write("] = ");

           

          
            Console.WriteLine();
        }
    }
}
