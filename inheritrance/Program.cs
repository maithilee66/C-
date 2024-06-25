using INHERITANCE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace INHERITANCE
//{

    class SHAPES
    {
        public int _width;
        public int _height;
        
        public SHAPES()
        {
        Console.WriteLine("constructor of shape class executed when object of {0} class was created", this);
        }
        public void shapeFunction()
        {
            Console.WriteLine("function in SHAPE CLASS called by {0} class object",this);

         }
    }
    class SQUARE : SHAPES
    {
        //this class SQUARE inherites property from shape class
     
        public int AreaOfSquare()
        {
            return _width * _height;
        }
        public SQUARE()
        {
            Console.WriteLine("constructor of sqare class executed when object of {0} class was created", this);
           }
}

    class TRIANGLE : SHAPES
    {
        //this class TRIANGLE inherites property from shape class

        public int AreaOfTriangle()
        {
            return _width * _height/2;
        }

    public TRIANGLE()
    {
        Console.WriteLine("constructor of triangle class executed when object of {0} class was created" +
            "", this);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        
         Console.WriteLine("1. initialization concept");
        Console.WriteLine("------------------------------------------------------");
        //to run initialization.cs 

         
        initialization init = new initialization();

        Console.WriteLine("-when object of derived class is created");
        DerivedClass d = new DerivedClass();

        Console.WriteLine("-when object of base class is created");
        BaseClass b = new BaseClass();  
        Console.WriteLine("------------------------------------------------------\n\n");

        

        Console.WriteLine("2. INHERITANCE concept");
        Console.WriteLine("------------------------------------------------------");
        TRIANGLE triangle =new TRIANGLE();

            triangle.shapeFunction();

        //accessing variable of base class from derived class
        //note that width and height variable are not present in triangle class but present in shape class(base class)
            triangle._width = 6;
            triangle._height = 2;
            Console.WriteLine("Area of triangle:{0}", triangle.AreaOfTriangle());




            SQUARE square=new SQUARE();
            square.shapeFunction();
        //accessing variable of base class from derived class
        //note that width and height variable are not present in triangle class but present in shape class(base class)
        square._width = 6;
        square._height = 2;
        Console.WriteLine("Area of square:{0}", square.AreaOfSquare());

        Console.ReadLine();
        }
    }
//}
