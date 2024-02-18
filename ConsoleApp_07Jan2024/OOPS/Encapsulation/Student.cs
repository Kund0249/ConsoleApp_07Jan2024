using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Encapsulation
{
     class Student
    {
        private int _RollNo;
        private string _Name;
        public int RollNo
        {
            get { return _RollNo; }
            set
            {
                if (value > 0)
                    _RollNo = value;
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if(!(string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value)))
                {
                    _Name = value;
                }
            }
        }
    }
}
