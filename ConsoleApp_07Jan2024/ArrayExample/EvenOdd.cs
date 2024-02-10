using System;
using System.Linq;

namespace ConsoleApp_07Jan2024.ArrayExample
{
    class EvenOdd
    {
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            int[] Numbers = new int[5];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("N{0} : ", (i + 1));
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Get Even Numbers

            int[] EvenNumbers = (from n in Numbers
                                 where n % 2 == 0
                                 select n).ToArray();

            //Get Odd Numbers
            var OddNumbers = from n in Numbers
                             where n % 2 == 1
                             select n;

            Console.Write("Even Numbers : ");
            foreach (int n in EvenNumbers)
            {
                Console.Write(n + "  ");
            }
            Console.WriteLine();

            Console.Write("Odd Numbers : ");
            foreach (int item in OddNumbers)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();


            //getting sum of all number
            int Sum = 0;

            foreach (int value in Numbers)
            {
                Sum = Sum + value;
            }

            Console.WriteLine("Sum : " + Sum);


            //Getting prime numbers
            var primenumbers = from n in Numbers
                               where IsPrime(n) == true
                               select n;

            Console.Write("Prime Numbers : ");

            foreach (int item in primenumbers)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            //Get All Prime Numbers

            /*
               select EmpId from Employee where EmpId = 1;
               select Name from Employee where EmpId % 2 = 1
               select Name from Employee where EmpId % 2 = 0
             */
        }
    }
}
