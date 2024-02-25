using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Inheritance
{
   public class GoldLoan : Loan
    {
        public float GW { get; set; }
        public float PricePerGram { get; set; }

        public override void Disburse()
        {
            throw new NotImplementedException();
        }
    }
}
