using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.ExcaptionHandling
{
    class Demo
    {
        static void Main(string[] args)
        {
            //Error : Syntac error and Logical Error

            try
            {
                Console.Write("Enter Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"you are {age} years old!");

                //Console.WriteLine("Program end!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter integer value!");
            }
            catch (Exception ex)
            {
                //log the error
                //throw ex;
                Console.WriteLine("There is some problem in application");
            }
            finally
            {
                Console.WriteLine("Program end!");
            }
           
        }
    }
}
