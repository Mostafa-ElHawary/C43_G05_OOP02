using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02.Inheritance
{
    internal class Parent
    {
        public int x { get; set; }
        public int y { get; set; }


        public void Fun01()
        {
            Console.WriteLine("Iam  Parent [Base]");
        }

        public void Fun02()
        {
            Console.WriteLine($"{x} , {y}");
        }

        //public Parent()
        //{

        //}

        public Parent(int x , int y ) { 
        
            this.x = x;
            this.y = y;
        }


        public override string ToString() {

            return $"{x} , {y} " ; 
        }
    }
}
