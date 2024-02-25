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
            GoldLoan GL = new GoldLoan();
            Console.Write("Enter Princple Amount : ");
            GL.PA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Tenure  : ");
            GL.Tenure = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ROI  : ");
            GL.ROI = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total Intrest : " + GL.GetTotalIntrest);

            Console.WriteLine("Total Payable : " + GL.GetPayableAmount);

            Console.WriteLine("Monthly EMI : " + GL.GetMonthlyEMI);

            //  GoldLoan GL = new GoldLoan()
            //  {
            //      AccountNumber = "y16356735671",
            //      AccountHolder = "John",
            //      ROI = 5,
            //      PricePerGram = 4400,
            //      GW = 39,
            //      PA = 100000,
            //      Tenure = 2
            //  };

            //float PA =  GL.GetPayableAmount();

            //Loan loan = new Loan();
        }
    }
}
