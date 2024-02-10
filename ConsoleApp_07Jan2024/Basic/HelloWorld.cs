using System;
using ConsoleApp_07Jan2024.Methods;

namespace ConsoleApp_07Jan2024.Basic
{
    class HelloWorld
    {
        public void Foo()
        {

        }
        public static void Main()
        {

            MathUtility utility = new MathUtility();
            int sum = utility.Add(10, 20);

            byte n = 255; //1 byte +
            sbyte n2 = 127;//1 byte (+,-)

            short a = 32767; // 2 byte (+,-)
            ushort ab = 50000; // 2 byte +

            int n3 =  2147483647; // 4 byte
            uint n4 = 4294967295; // 4 byte -

            long n5 =  9223372036854775807; // 8 byte +,-
            ulong n6 = 18446744073709551615; //8 byte +

            //Rule 1 : it should always start with char or _
            //Rule 2 : There should not be any space in between Variable

            Console.Write("Enter Name : ");
            string StatudentName = Console.ReadLine();

            Console.Write("Enter Age : ");
            int StudentAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Fee : ");
            float Fee = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Name : " + StatudentName);
            Console.WriteLine("Age : " + StudentAge);
            Console.WriteLine("Fee : " + Fee);
        }
    }
}
