using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ArrayExample
{
    class ArrayExample
    {
        static void Main(string[] args)
        {
            int[] Values = new int[3];
            //Values[0] = Convert.ToInt32(Console.ReadLine());
            //Values[1] = Convert.ToInt32(Console.ReadLine());
            //Values[2] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Values.Length; i++)
            {
                Console.Write("N{0} : ",i+1);
                Values[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.Write(Values[0] + "\t");
            //Console.Write(Values[1] + "\t");
            //Console.Write(Values[2] + "\t");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(Values[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
