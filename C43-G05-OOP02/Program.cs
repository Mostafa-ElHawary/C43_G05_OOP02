using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using C43_G05_OOP02.Binding;
using C43_G05_OOP02.Inheritance;
using C43_G05_OOP02.Overriding;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C43_G05_OOP02
{
    internal class Program
    {

        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    employee.Func01();
        //    employee.Func02();
        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    employee.Func01();
        //    employee.Func02();
        //}

        static void EmployeeProcess(Employee employee)
        {
            if (employee is not null) { 
            
            employee.Func01();
            employee.Func02();
            }
        }

        static void Main(string[] args)
        {

            #region Revision Class vs Struct

            //                                     Class                           vs                         Struct



            // - data type                         reference type                                             Value type 

            // - Object                            store in heap                                              store in Stack

            // - when create boject                reference create at stack and he ref                       just object created in stack
            //                                     to the Object in heap              

            // - 4 pillers                         Apply or support the 4 pillers                             just support encapsulation and part of polymorphism

            // - new                               the new is for create object                               the new here for constructor

            // - default constructor               do nothing and when build user defind constructor          initilize the attributes with the default value                                            
            //                                     the default constructor will be canceled                   when build user defind constructor is he pramaterless the default will be canceld 
            //                                                                                                but if he is parameterizzed will not canceled the default

            // -life time                          have a life time taller than struct                        is be shorter
            //                                     because the data still there in heap untill 
            //                                     the carbig collecter removed 

            //- access modifire                    private , private protected ,protected                     private , internal , public   
            //                                     ,internal , internal protected 

            //when to use                          if the data is complex and large                          of the scale of data is small
            //                                     but if You benefit with the class feature
            //                                     use class
            #endregion

            #region Inheritance


            Parent parent = new Parent(1,2);

            parent.Fun01();
            parent.Fun02();

            Child child = new Child(1, 2, 3);

            //Console.WriteLine(child.ToString());

            child.Fun01();
            child.Fun02();

            // 36:56
            #endregion

            // Relationships Between classess
            // 1. Inheritance : is a Relationship
            // child ----> parent
            // child is a parent

            //2. Association: has a Relationship
            // Book has a Author 

            // 2.1 Composition   : has a Relationship like i class of car should to have a wheel class
            // 2.2 Aggregation  : has a Relationship like a class of person have a class of radio but the class person not nessary contain radio

            #region Polymorphism

            // Polymorphism Methods (functions) OverLoading
            // Polymorphism Methods (functions) OverRiding
            // there are more than on functions [in different class] these have the same name and 
            // the same signature but with behaivour





            #endregion

            #region Override & overload & binding


            //In C#, both overriding and overloading are powerful tools that provide flexibility and extensibility in object-oriented programming. They deal with how methods are defined and called, but they operate in different ways.

            //Overriding(Runtime Polymorphism)

            //Overriding occurs when a derived class provides a specific implementation for a method that is already defined in its base class. The derived class method overrides the base class method. This is a fundamental aspect of polymorphism.

            //Key features of overriding:

            //Inheritance: Overriding happens between a base class and a derived class.

            //Virtual/Override keywords: The base class method must be marked virtual, abstract, or override. The derived class method must be marked override.

            //Same signature: The overridden method in the derived class must have the same name, return type, and parameters as the base class method.

            //Runtime binding: The decision of which method to call(base or derived) is made at runtime based on the actual object type.


            //Overloading(Compile - Time Polymorphism)

            //Overloading allows a class to have multiple methods with the same name but different parameters(either different number of parameters or different parameter types). The compiler determines which method to call based on the arguments provided at compile time.

            //Key features of overloading:

            //Same class: Overloading happens within the same class.

            //Different signatures: Overloaded methods must have different parameter lists.The return type can be different, but that alone is not sufficient for overloading.

            //Compile-time binding: The decision of which overloaded method to call is made at compile time.


            #endregion


            FullTimeEmployee fullTime = new FullTimeEmployee()
            {

                Id = 1,
                Name = "Ali",
                Address = "Cairo",
                Email = "e@g.c",
                Salary = 29990

            };

            PartTimeEmployee partTime = new PartTimeEmployee()
            {
                Id = 1,
                Name = " so",
                Address = "alex",
                Email = "alex@g.c",
                HourRate = 242,
                NumberOfHour = 1,

            };

            fullTime.Func01();
            fullTime.Func02();
            
            EmployeeProcess(fullTime);
            EmployeeProcess(partTime);

            // stoped at 2:06:55

        }


        TypeA typeA ;

      
    }
}
