using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02.Inheritance
{
    internal class Child : Parent
    {
        // as a default the child class will make call or chain on the default parent constructor 
        // so if you create a user defind constructor it's will be canceled the default constructor 
        // so depend on that will be showed the issue because the child class will want to call the default 
        // constructor but he doent found it and depend on that will show the issu 
        // so to solve this issue we can build the default constructor it's will be emplty 
        // or we can make the child call or chian on the existing user defind constructor 

        //public Child() : base(1,2 ) { }

        //Note we should using :base not :this because the :base usage between deferent class 
        // but :this usage if the child class is there in the same parent class 

        public int z { get; set; }
        public Child(int x , int y, int z   ) : base(x, y )
        {
            this.z = z;
        }

        public void Fun01()
        {
            Console.WriteLine("Iam  Child [Base]");
        }

        public void Fun02()
        {
            Console.WriteLine($"{x} , {y} , {z}" );
        }

        public override string ToString()
        {
            return $"{x} , {y} , {z}";
        }

    }
}
