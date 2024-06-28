using System;

//method Hiding vs Method Overriding
/*
 --------METHOD HIDING------------------
 new Keyword:

new is used to explicitly hide a member of a base class in a derived class.
When you use new on a method, you're essentially saying that you are defining
a new method with the same name and signature as a method in the base class, but 
it is not overriding it.

 --------METHOD OVERRIDING------------------
virtual and override Keyword:

1.virtual is used in a base class 
to declare a method, property, or indexer that can
be overridden by derived classes.

2. override is used in a derived class to provide a new implementation of a method, 
property, or indexer that was declared as virtual in the base class.
It indicates that the derived class is replacing (or overriding) the base class 
implementation with its own implementation.



*/
class BASECLass
{
    public void Draw()
    {
        Console.WriteLine("Baseclass draw function");
    }
}
class A: BASECLass
{
    public new void Draw()
    {
        Console.WriteLine("A Class draw function");
    }
}


class Base2
{
    public virtual void Draw2()
    {
        Console.WriteLine("Baseclass draw function");
    }
}
class A2 : Base2
{
    public override void Draw2()
    {
        Console.WriteLine("A Class draw function");
    }
}
namespace MethodHideing_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //method hiding using new keyword 
            BASECLass B= new BASECLass(); ;
            B.Draw();//Baseclass draw function

            BASECLass a= new A() ;
            a.Draw();//Baseclass draw function

            A A_= new A() ;
            A_.Draw(); //A

            Console.WriteLine("---------------------------------");
            //method overriding using override keyword 

            Base2 B2 = new Base2(); ;
            B2.Draw2();//Baseclass draw function

            Base2 a2 = new A2();
            a2.Draw2();//a  

            A2 a_2 = new A2();
            a_2.Draw2(); //A
            Console.ReadLine();
/*
            OUTPUT:
           Baseclass draw function
           Baseclass draw function
           A Class draw function
        ---------------------------------
           Baseclass draw function
           A Class draw function
           A Class draw function
*/
        }
    }
}
