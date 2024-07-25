using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHiding
{

     class A
    {
        public void f()
        {
            Console.WriteLine("A f()");
        }
    }

    //In class B1 method hiding is NOT done
    class B1:A
    {
        public void f()
        {
            Console.WriteLine("B1 f()");
        }
    }

    //In class B2 method hiding is  DONE
    class B2 : A
    {
        public new void f()
        {
            Console.WriteLine("B2 f()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //Creating object of derived class with no method hiding
            Console.WriteLine("Creating object of derived class with no method hiding");
            B1 b1 = new B1();
            b1.f();
            Console.WriteLine("------------------------------------------------");
            //Creating object of derived class with  method hiding
            Console.WriteLine("Creating object of derived class with  method hiding");
            B2 b2 = new B2();
            b2.f();
            Console.WriteLine("------------------------------------------------");


            //BUT now if you want to call base class function only we can do
            Console.WriteLine("after applying method hiding and using new keyowrd in derived class ");
            Console.WriteLine("if you want to call base class function then there are two methods to do");
            Console.WriteLine(" --method1 A b = new B2(); \n Method2: do B2 B = new B2(); ((A)B).f();--  ");
            A b = new B2();
            b.f();

            B2 B = new B2();
            ((A)B).f();
            
            Console.WriteLine("------------------------------------------------");

            Console.ReadLine();
        }
    }
}
