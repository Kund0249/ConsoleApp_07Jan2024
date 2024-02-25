using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Jan2024.OOPS.Polymorphism
{
   public class MethodOverriding
    {
        public virtual void Foo()
        {
            Console.WriteLine("This is Foo Method");
        }
    }

    public class MyClass : MethodOverriding
    {
        public override void Foo()
        {
            Console.WriteLine("This is overrided Foo Method");
        }
    }
}
