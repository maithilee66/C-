using System;


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
        //for both interface same function will be executed as both interface function are 
        //having same name 
        public void print() {
            Console.WriteLine("this is print function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A obj = new A(); obj.print();");
            A obj = new A();
          obj.print();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("IOne obj1 = new A();  obj1.print();");
            IOne obj1 = new A();
            obj1.print();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ITwo obj2 = new A();   obj2.print();");
            ITwo obj2 = new A();
            obj2.print();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("In order to have different method for different interface we need to do explicit implemenattion of it");

            Console.ReadLine();
        }
}
}
