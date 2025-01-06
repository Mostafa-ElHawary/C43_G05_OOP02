using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP02
{
    internal class Person
    {
        private string Name;
        private int Age;
        private string Address;

       

        public Person(string name, int age, string address) :this(name,age)
        {
            // Name = name;
            // Age = age;
            // Person(name, age);
            Address = address;
        }

         public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}
