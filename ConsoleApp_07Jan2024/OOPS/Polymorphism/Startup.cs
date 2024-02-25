using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingServices;

namespace ConsoleApp_07Jan2024.OOPS.Polymorphism
{
    class MyCustomeEmailClient : EmailClient
    {
        public override void Send(string From, string To, string MessageBody)
        {
            base.Send(From, To, MessageBody);
            //logic to log this email
            Console.WriteLine("Email Logged to our local DB");
        }
    }
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Roll No. {RollNo} Name : {Name}";
        }
    }
    class Startup
    {
        static void Main(string[] args)
        {

            IEmailClient client = new EmailClient();
            client.Send("k@gmail.com", "test@gmail.com", "Hi");

            //int N1 = 10;
            //int N2 = 20;

            //Console.WriteLine(10.ToString()+20.ToString());

            //Student student = new Student() { RollNo = 1, Name = "John" };
            //Console.WriteLine(student.ToString());

            //MethodOverLoading ob = new MethodOverLoading();

            //var sum = ob.Add(10, 20.5F);

            //MailService service = new MailService();
            //service.Send("k@gmail.com", "test@gmail.com", "Hii", "Thank & Regards\n Kundan");

            //Console.WriteLine("Sum : " + sum);

            //int N1 = 10;
            //string Name = "Kundan";
            //bool IsMarried = true;
            //float ab = 10.5F;

            //Console.WriteLine(N1);
            //Console.WriteLine(Name);
            //Console.WriteLine(IsMarried);
            //Console.WriteLine(ab);

            //MyClass ob = new MyClass();

            //ob.Foo();
        }
    }
}
