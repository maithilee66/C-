using System;
using System.Security.Policy;

//Explicit Interface Implementations

namespace Interfaces
{

  
    interface IOne
    {
        void print();

    }

    interface ITwo
    {
        void print();

    }

    class A : IOne, ITwo
    {
        /*
         as both interfaces have same name in order to keep print() method of interface one and interface two different 

         define the method as
         interfacename.methodName without giving access specifier

        void IOne.print() {}
        void Itwo.print() {}
         */
        void IOne.print(){
            Console.WriteLine("this is IOne print function");
        }
        void ITwo.print()
        {
            Console.WriteLine("this is ITwo print function");
        }
        public void print()
        {
            Console.WriteLine("public void print()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A obj = new A(); obj.print(); this will give error  ");
            A obj = new A();

            //obj.print();

            //this will give error 
            //to print we have to use typecasting

            Console.WriteLine("((IOne)obj).print(); Will print ");

            ((IOne)obj).print();

            Console.WriteLine("((ITwo)obj).print(); Will print ");
            ((ITwo)obj).print();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("IOne obj1 = new A();  obj1.print(); will print IOne.print");
            IOne obj1 = new A();
            obj1.print();


            Console.WriteLine("------------------------------------");
            Console.WriteLine("ITwo obj2 = new A();   obj2.print();   will print ITwo.print");
            ITwo obj2 = new A();
            obj2.print();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("A obj = new A(); inorder to call obj.print(); we need to create a public method print() in class A ");
           obj.print();
            Console.ReadLine();
        }
}
}

    
  

