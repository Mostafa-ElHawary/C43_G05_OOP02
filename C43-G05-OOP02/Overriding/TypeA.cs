using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02.Overriding
{
    internal class TypeA
    {
        public int A { set; get; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From TypeA");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"{A}");
        }

    }
}
