using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { set; get; }

        // to make override on the functions there at TypeA
        // i will take them paste and copy here  and we  change the body of then 

        // Note : to Apply the override we have two way 
        // 1. Apply override using 'new' keyword
        // the new case is the default happend ex on Fun01 in the default
        //  the func01 will be => public void Fun01() and with using new => public new void Fun01() 
        // 2. Apply override using 'override' keyword
        // when i need to use override keyword i will type a override like Fun02
        // and should the Fun02 in the base class should to have a virtual keyword
        public void Fun01()
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        public override void Fun02()
        {
            Console.WriteLine($"{A} , {B}");
        }
    }
}
