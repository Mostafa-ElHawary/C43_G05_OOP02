using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02
{
        class TypeA
        {
            public int A { get; set; }

            public void Func01()
            {
                Console.WriteLine("Func01 from TypeA");
            }
            public virtual void Func02()
            {
                Console.WriteLine($"A{A}");
            }
        }

        class TypeB : TypeA
        {
            public int B { get; set; }

            public new void Func01()
            {
                Console.WriteLine("Func01 from TypeB");
            }
            public override void Func02()
            {
                Console.WriteLine($"A : {A} ,B : {B} ");
            }
        }

    class TypeC : TypeB
    {
        public int C { get; set; }

        public new void Func01()
        {
            Console.WriteLine("Func01 from TypeC");
        }
        public override void Func02()
        {
            Console.WriteLine($"A : {A} ,B : {B} , C : {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }

        public new void Func01()
        {
            Console.WriteLine("Func01 from TypeD");
        }
        public override void Func02()
        {
            Console.WriteLine($"A : {A} ,B : {B} , C : {C} , D : {D}");
        }
    }
}