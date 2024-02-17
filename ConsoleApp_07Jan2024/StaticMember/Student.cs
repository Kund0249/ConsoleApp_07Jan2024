using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.StaticMember
{
   public class Student
    {
        //Instance Member
        public int RollNo;
        public string Name;

        //Static Member
        public static int Count;
        public Student()
        {
            Count++;
        }

        static Student()
        {
            Count = 0;
        }
    }
}
