using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.Generics_Example
{
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
    class GenericList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //list.Add(new Department() { 
            //DeptId =1,
            //DeptName="Test"
            //});
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            int n = list.Find(x => x == 100);
            Console.WriteLine("Search Element : " + n);
            //list.Remove(10);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
