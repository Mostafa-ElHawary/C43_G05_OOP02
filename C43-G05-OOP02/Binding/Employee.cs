using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }


        public void Func01()
        {
            Console.WriteLine("IAM EMPLOYEE");
        }

        public virtual void Func02()
        {
            Console.WriteLine($"Salary : ??? ");
        }
    }
}
