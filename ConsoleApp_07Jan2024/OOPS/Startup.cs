using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS
{
    class Startup
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            Employee e1 = new Employee()
            {
                EmpId = 1,
                EmpName = "A",
                Gender = "F",
                Mob = "4455667434",
                Salary = 480000
            };

            Console.WriteLine($"Id : {e1.EmpId}");
            Console.WriteLine($"Name : {e1.EmpName}");
            Console.WriteLine($"Gender : {e1.Gender}");
            Console.WriteLine($"Mob : {e1.Mob}");
            Console.WriteLine($"Salary : {e1.Salary}");
            Console.WriteLine("-----------------------");
            Employee e2 = new Employee()
            {
                EmpId = 2,
                EmpName = "B",
                Gender = "M",
                Mob = "4455667434",
                Salary = 480000
            };

            Console.WriteLine("Id : " + e2.EmpId);
            Console.WriteLine($"Name : {e2.EmpName}");
            Console.WriteLine($"Gender : {e2.Gender}");
            Console.WriteLine($"Mob : {e2.Mob}");
            Console.WriteLine($"Salary : {e2.Salary}");
        }
    }
}
