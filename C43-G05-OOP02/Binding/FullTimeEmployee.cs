using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02.Binding
{
    internal class FullTimeEmployee : Employee
    {

        

        public double Salary { get; set; }

        public new void Func01()
        {
            Console.WriteLine("IAM FULLTIMW EMPLOYEE");
        }

        public override void Func02()
        {
            Console.WriteLine($"{Salary}");
        }
    }
}
