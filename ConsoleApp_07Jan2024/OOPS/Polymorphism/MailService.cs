using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Polymorphism
{
   public class MailService
    {
        public void Send(string From, string To, string Body, string Signature)
        {
            //
            Console.WriteLine("Mail Sent From : " + From);
            Console.WriteLine("Mail Sent TO : " + To);
        }


        public void Send(string From, string To,string CC ,string Body, string Signature)
        {
            //
        }

        public void Send(string From, string To, string Body, string Signature,uint Attachement)
        {
            //
        }

        public void Send(string From, string To, string CC, string Body, string Signature,uint Attachement)
        {
            //
        }

        public void Send(string From, string To, string CC, string Body, string Signature, uint[] Attachement)
        {
            //
        }

        public void Send(string From, string To, string Body, string Signature, uint[] Attachement)
        {
            //
        }
    }
}
