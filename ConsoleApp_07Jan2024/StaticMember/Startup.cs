using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.StaticMember
{
    class Startup
    {
        static void Main(string[] args)
        {
            Student S1 = new Student()
            {
                RollNo = 1,
                Name = "A"
            };

            Student S2 = new Student()
            {
                RollNo = 2,
                Name = "B"
            };

            Student S3 = new Student()
            {
                RollNo = 3,
                Name = "B"
            };

            Console.WriteLine("Total Student : " + Student.Count);
        }
    }
}
