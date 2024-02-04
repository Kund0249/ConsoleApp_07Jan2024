using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ArrayExample
{
    //Assignment - collect 5 int value from the user in array and find out odd and even from the array
    //Assignment - collect 5 int value from the user in array and sum of all
    //Assignment - collect 5 int value from the user in array and find out prime number from the array
    class MultiDimentionArray
    {
        static void Main(string[] args)
        {
            int[,] Values = new int[2, 3];

            //Console.Write("N1 : ");
            //Values[0, 0] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("N2 : ");
            //Values[0, 1] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("N3 : ");
            //Values[1, 0] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("N4 : ");
            //Values[1, 1] = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("Values[{0}, {1}] : ",row,col);
                    Values[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine(Values[row,col]);
                }
            }
        }
    }
}
