using Microsoft.SqlServer.Server;
using System;
/*
 

    1. we cannot create a object of abstract class
    --------------------------------
    2. abstract class are used as base class and need to be derived by another class therfore the members of abstract class are 
        accessed via derived class objects.
   ------------------------------
    3. abstract class can have abstarct method or/and  normal method 
        -----------abstract method 
               abstract method are only declared in abstract class this method are declared in derived class 
               by overriding the abstract method method in derived class
                
            abstract class Animal
             {
                //abstract method f1()
                 public abstract void f1();
             }

            class Derived: Animal
            {
                public override void f1() 
                { 
                    Console.WriteLine("this is abstract method f1()");
                }
            }

       -----------normal method
               normal method can be declared and defined in abstract class
           abstract class Animal
            {
      
                //normal method f2()
                 public void f2()
                 {
                    Console.WriteLine("this is normal method f2()");
                  }
            }
------------------------------------------------------------
    4. abstract method cannot be private 
    abstract method cannot be declared as static or declared virtual
    (these rules are only for abstract method not for normal method)
 --------------------------------------------------------------
       5. the abstract class cannot be sealed class 
       (sealed class is a class which states that this class cannot be used as base class)
         
         public abstract sealed class animal{
            //this is wrong 
          } 

 --------------------------------------------------------------------

 */

namespace Abstraction
{

    abstract class Animal
    {
        //abstract method f1()
        public abstract  void f1();


        //normal method f2()
        public  void  f2()
        {
            Console.WriteLine("this is normal method f2()");
        }
    }

    class Derived: Animal {

        public override void f1() 
        { Console.WriteLine("this is abstract method f1()"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            obj.f1(); //his is abstract method f1()"
            obj.f2(); //this is normal method f2()"

            Console.WriteLine("-------------------------------------------------");

            // Animal objAnimal = new Animal(); // This line will cause a compilation error

            // Correct usage: Instantiate Derived class through Animal reference
            Animal objAnimal = new Derived();
            objAnimal.f1(); // Output: "This is abstract method f1()"
            objAnimal.f2(); // Output: "This is normal method f2()"
            Console.ReadLine();
        }
    }
}
