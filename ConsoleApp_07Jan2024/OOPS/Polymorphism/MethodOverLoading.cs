using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Polymorphism
{
   public class MethodOverLoading //Basic Calculator
    {
        public int Add(int V1, int V2)
        {
            return V1 + V2;
        }

        //public int Add(int a, int b)
        //{
        //    return a+b;
        //}

        public float Add(float V1, int V2)
        {
            return V1 + V2;
        }

        public float Add(int V1, float V2)
        {
            return V1 + V2;
        }
    }
}
