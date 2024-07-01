using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{      
    interface IMeter
    {       
        void print();
        /*
        1. interface cannot have member variables (eg . int a; etc) it can only have methods
        2. interface cannot have method defination (eg. void print(){})
             it can only have method declaration (eg. void print();)
        3. Method can not have any access modifier (eg public void print();) buy default
              the access is set as abstract And public

        */
    }
    class A : IMeter
    {
        public void print()
        {
            Console.WriteLine("this is print method ");
        }

        /*
         4. The method declared in interface need to be defined in class and this class should inherit
            from the interface (eg. class A : IMeter {})
         5. here the method  do have access modifier and entire defination (public void print(){ })
         */
    }
    class Program
    {
        static void Main(string[] args)
        {

            A objA = new A();
            objA.print();
            Console.ReadLine();
        }

        /*
         6. interface isAnother way to achieve abstraction in C#,An interface 
            is like a  completely "abstract class"

         7. It is considered good practice to start with the letter "I" at the beginning 
            of an interface, as it makes it easier for yourself and others to remember 
            that it is an interface and not a class.

         8. By default, members of an interface are abstract and public.

         9. Interfaces can contain properties and methods, but not fields

         10. To access the interface methods, the interface must be "implemented" (kinda like inherited) 
            by another class. To implement an interface, use the : symbol (just like with inheritance). 
            you do not have to use the override keyword when implementing an interface:

        11. Like abstract classes, interfaces cannot be used to create objects 
        (in the example above, it is not possible to create an "IMeter" object in the Program class)

        12. On implementation of an interface, you must override all of its methods

        13. Interfaces can contain properties and methods, but not fields/variables(for this point read the
            interface.txt file)

        14. An interface cannot contain a constructor (as it cannot be used to create objects)

        15.Interface members are by default abstract and public
         */
    }
}
