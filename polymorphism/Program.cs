using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    class SHAPE_FIRST
    {
        public SHAPE_FIRST() { }
        public virtual void draw()
        {
            Console.WriteLine(" SHAPE_FIRST draw");
        }
    }
    class Triangle : SHAPE_FIRST
    {
        public  override void draw()
        {
            Console.WriteLine(" circle draw");
        }
    }

    class Square : SHAPE_FIRST
    {
        public override void draw()
        {
            Console.WriteLine(" Square draw");
        }
    }

    class Rectangle : SHAPE_FIRST
    {
        public override void draw()
        {
            Console.WriteLine(" Rectangle draw");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SHAPE_FIRST SF = new SHAPE_FIRST();
            SHAPE_FIRST c = new Triangle(); // Creating instance of circle
            SHAPE_FIRST s = new Square(); // Creating instance of Square
            SHAPE_FIRST r = new Rectangle(); // Creating instance of Rectangle
            Square S = new Square();
            SF.draw(); //Output: SHAPE_FIRST draw
            c.draw(); // Output: circle draw
            s.draw(); // Output: Square draw
            r.draw(); // Output: Rectangle draw
            s.draw(); //Output: Square draw
            Console.ReadLine();
        }
    }
}
