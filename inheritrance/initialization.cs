using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{

    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BASE CLASS constructor executed");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived CLASS constructor executed");
        }
    }
    class initialization
    {
        //this is to underatand that when a object is created from derived class the 
        //base class is initialized first then derived class is initialized

        DerivedClass d=new DerivedClass();


    }
}
