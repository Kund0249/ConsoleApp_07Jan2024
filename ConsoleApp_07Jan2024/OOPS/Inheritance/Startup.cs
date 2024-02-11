using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Inheritance
{
    class Startup
    {
        static void Main(string[] args)
        {
            GoldLoan loan = new GoldLoan()
            {
                AccountNumber = "371853715",
                AccountHolder = "A",
                GoldWeight = 32,
                PrincpleAmount = 1029029,
                ROI = 5,
                Tenure = 2,
                Iteams = new string[]{"Ring","Chanin"}
            };
        }
    }
}
