using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Inheritance
{
    class PersonalLoan : Loan
    {
        public int CurrentSalary { get; set; }
        public string OrgName { get; set; }
        public string MyProperty { get; set; }

        public override void Disburse()
        {
            //code
        }
    }
}
