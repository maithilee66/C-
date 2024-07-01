using System;
using System.Security.Policy;

//Multiple Interfaces
/*
    C# does not support "multiple inheritance" (a class can only inherit from one base class). 
    However, it can be achieved with interfaces, because the class can implement multiple interfaces.
    Note: To implement multiple interfaces, separate them with a comma (see example below).

*/
namespace Interfaces
{      
    interface IOne
    {       
        void O1();
     
    }

    interface ITwo
    {
        void T2();

    }

    interface ITHREE
    {
        void T3();

    }
    class A : IOne,ITwo, ITHREE
    {
        public void O1()
        {
            Console.WriteLine("this is ONE");
        }

        public void T2()
        {
            Console.WriteLine("this is TWO");
        }

        public void T3()
        {
            Console.WriteLine("this is THREE");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            A objA = new A();
            objA.O1();
            objA.T2();
            objA.T3();



            /*
            we can  create obj of interface poiniting to the inheriting class
            IOne one = new A(); //right

            but we cannot create obj of interface pointing to interface
             IOne one = new IOne(); //wrong 
           */
            Console.WriteLine("-------------------------------------------------------------");
            IOne one = new A();
                one.O1();
                //one.T2(); //wrong as t2 method is defined in interface Itwo hence
                //cant be accessed through obj of interface Ione
                
                ITwo two = new A();
                 two.T2();
            //two.O1(); //wrong as o1 method is defined in interface Ione hence
            //cant be accessed through obj of interface Itwo

            



            Console.ReadLine();
        }

    }
}
