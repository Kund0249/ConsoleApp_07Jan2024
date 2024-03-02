using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.Generics_Example
{
   static class Comparer
    {
        //public static bool Equal(int V1,int V2)
        //{
        //    if (V1 == V2)
        //        return true;

        //    return false;
        //}

        //public static bool Equal(object V1, object V2)
        //{
        //    if (V1 == V2)
        //        return true;

        //    return false;
        //}

        public static bool Equal<T>(T V1, T V2)
        {
            dynamic _V1 = V1;
            dynamic _V2 = V2;

            if (_V1 == _V2)
                return true;

            return false;
        }
    }
}
