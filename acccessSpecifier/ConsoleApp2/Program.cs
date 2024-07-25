using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;


namespace ConsoleApp2
{
    class class3 : Class1
    {
   
        public void show3()
        {
            PublicMethod();
            ProtectedMethod();
            /*
            InternalMethod();
            PrivateMethod();
            */
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 c1= new Class1();
            c1.PublicMethod();
            /*
            c1.InternalMethod();
            c1.PrivateMethod();
            c1.ProtectedMethod();
            */
           
        }
    }
}
