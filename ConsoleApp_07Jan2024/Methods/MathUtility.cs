using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.Methods
{
    class MathUtility
    {
        //instance memeber function/Method
        public bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        public int Add(int N1, int N2)
        {
            int Sum = N1 + N2;
            return Sum;
        }

        //static memeber function

        public static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
 