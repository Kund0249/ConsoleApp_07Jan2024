using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ControlStatements
{
    class BasicCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter N2 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            //if(N1 == N2)   
            //    Console.WriteLine("N1 and N2 are equals");
            //else if(N1 > N2)
            //    Console.WriteLine("N1 is greater");
            //else
            //    Console.WriteLine("N2 is greater");

            
            TakeOperator:

            Console.Write("Select Operator [+ - * /] : ");
            //string op = Console.ReadLine();
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //if(op == "+")
            //    Console.WriteLine("Result : {0}",(N1+N2));
            //else if(op == "-")
            //    Console.WriteLine("Result : {0}", (N1 - N2));
            //else if (op == "*")
            //    Console.WriteLine("Result : {0}", (N1 * N2));
            //else if (op == "/")
            //    Console.WriteLine("Result : {0}", (N1 / N2));
            //else
            //    Console.WriteLine("OOPS! invalid input.");

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result : {0}", (N1 + N2));
                    break;
                case '-':
                    Console.WriteLine("Result : {0}", (N1 - N2));
                    break;
                case '*':
                    Console.WriteLine("Result : {0}", (N1 * N2));
                    break;
                case '/':
                    Console.WriteLine("Result : {0}", (N1 / N2));
                    break;
                default:
                    Console.WriteLine("OOPS! invalid input.");
                    goto TakeOperator;
            }

        }
    }
}
