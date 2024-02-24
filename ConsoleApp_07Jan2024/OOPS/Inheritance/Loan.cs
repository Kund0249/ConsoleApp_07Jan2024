using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Inheritance
{
   public abstract class Loan
    {
        private string _AccountNumber;
        public string AccountNumber 
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; } 
        }
        public string AccountHolder { get; set; }
        public int ROI { get; set; }
        public int PA { get; set; }

        public int Tenure { get; set; }

        //Non-Abstract Method
        public float GetPayableAmount()
        {
            //logic
            int TIA = (ROI * PA * Tenure) / 100;
            int total = PA + TIA;
            return total;
        }

        //Abstract Method
        public abstract void Disburse();
    }

    
}
