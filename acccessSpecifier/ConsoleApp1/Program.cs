using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Class1
    {
        private void PrivateMethod()
        {
            Console.WriteLine("Private method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal method");
        }

        public void show()
        {
            
            PublicMethod();
            InternalMethod();
            PrivateMethod();
            ProtectedMethod();
            
        }

    }

    public class Class2: Class1
    {
        public void show2()
        {

            PublicMethod();
            InternalMethod();
            ProtectedMethod();

        }
    }
    internal class Program:Class1
    {

        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------\n//1 within the application accessiblity");
            //1 within the application accessiblity

            //public method and internal method can be accessed
            Class1 c1=new Class1();
            c1.PublicMethod();
            c1.InternalMethod();
            /*
            //private method and protected cannot be accessed
            c1.PrivateMethod();
            c1.ProtectedMethod();
            */

            Console.WriteLine("------------------------------------------------------\n //2 within a class class1 all methods can be accessed");
            //2 within a class class1 all methods can be accessed

            Class1 obj2= new Class1();
            obj2.show();


            Console.WriteLine("------------------------------------------------------\n //3 from derived  class object only public and internal can be accessed");
            //3 from derived  class object only public and internal can be accessed

            Class2 obj= new Class2();
            obj.PublicMethod();
            obj.InternalMethod();

            /*
            obj.PrivateMethod();
            obj.ProtectedMethod();
            */

            Console.WriteLine("\n //3.2 but from derived class member method we can can access public , protected , internal method ");
            //but from derived class method  we can can access public , protected , internal method 

            obj.show2();
            Console.WriteLine("------------------------------------------------------\n //4 from another namespace only public method can be accessed");
            //4 from another namespace only public method can be accessed

            Console.WriteLine("------------------------------------------------------\n //5 from another namespace but in derived only Public and Protected can be accessed");
            //5 from another namespace but in derived only Public and Protected can be accessed



            Console.ReadLine();

        }
    }
}
