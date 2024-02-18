using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Encapsulation
{
    class Startup
    {
        static void Main(string[] args)
        {
            //Product p = new Product();

            // p.SetData(1, "TV", 32000);

            //p.SetId(1);
            //p.SetName("TV");
            //p.SetPrice(32000);

            //p.GetProduct();
            //int id = p.GetId();

            //Console.WriteLine($"Id : {p.GetId()} Name : {p.GetName()}");

            //Product p = new Product();
            //p.Id = 1;
            //p.Name = "TV";
            //p.Price = 32000;

            //Product p = new Product()
            //{
            //    Id = 1,
            //    Name = "TV",
            //    Price = 32000
            //};

            //Console.WriteLine($"Id : {p.Id} Name : {p.Name}");

            Student s = new Student()
            {
                RollNo = 10,
                Name = "John"
            };

            Console.WriteLine($"Roll No : {s.RollNo} Name : {s.Name}");


        }
    }
}
