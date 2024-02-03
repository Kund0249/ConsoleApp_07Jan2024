using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ControlStatements
{
    class DoWhileLoopDemo
    {
        static void Main(string[] args)
        {
            char ToContinue;
            do
            {
                Console.Write("Enter N1 : ");
                int N1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter N2 : ");
                int N2 = Convert.ToInt32(Console.ReadLine());

            TakeOperator:
                Console.Write("Select Operator [+ - * /] : ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

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


                Console.Write("Press Y to continue : ");
                ToContinue = Console.ReadKey().KeyChar;
                ToContinue = char.ToLower(ToContinue);
                Console.WriteLine();

            } while (ToContinue == 'y');

        }
    }
}
