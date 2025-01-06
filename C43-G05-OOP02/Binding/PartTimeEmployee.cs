using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02.Binding
{
    internal class PartTimeEmployee : Employee
    {
 
        public double HourRate { get; set; }

        public int NumberOfHour { get; set; }

        public new void Func01()
        {
            Console.WriteLine("IAM parttime EMPLOYEE");
        }

        public override void Func02()
        {
            Console.WriteLine($"{HourRate * NumberOfHour}");
        }
    }
}
