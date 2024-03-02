using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.Enumeration
{
    public enum NotificationType
    {
        success, warrning, error, info
    }
    public static class Notification
    {
        //public static void Notify(string Message,string NotificationType)
        //{
        //    switch (NotificationType)
        //    {
        //        case "success":
        //            Console.WriteLine("Green : " + Message);
        //            break;
        //        case "warrning":
        //            Console.WriteLine("organe : " + Message);
        //            break;
        //        case "info":
        //            Console.WriteLine("sky blue : " + Message);
        //            break;
        //        case "error":
        //            Console.WriteLine("Red : " + Message);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        public static void Notify(string Message, NotificationType type)
        {
            switch (type)
            {
                case NotificationType.success:
                    Console.WriteLine("Green : " + Message);
                    break;
                case NotificationType.warrning :
                    Console.WriteLine("Orange : " + Message);
                    break;
                case NotificationType.info:
                    Console.WriteLine("sky blue : " + Message);
                    break;
                case NotificationType.error:
                    Console.WriteLine("red : " + Message);
                    break;
                default:
                    break;
            }
        }
    }
}
