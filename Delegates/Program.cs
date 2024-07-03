using System;


namespace Delegates
{
    public delegate void calcDelegate(int a, int b);
     class Program
    {
        /* 
         Add and Subtraction are non static method
         divide and Multiply are static method 
        */
        public void Add(int x, int y)
        {
            Console.WriteLine("add={0}",x+y);
        }
        public void Subtraction(int x, int y)
        {
            Console.WriteLine("Subtraction={0}", x - y);
        }

        public static void Divide(int x, int y)
        {
            Console.WriteLine("Divide={0}", x / y);
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiplication={0}", x * y);
        } 

        static void Main(string[] args)
        {
            //1. to call non static method sub and mul
            /* as main is a static method and sub and add are non static method we cannot call non static method
             from static method without instance
            therefore there we have to create a instance then call the non static method via that  instance 
            */

            Program p = new Program();

            calcDelegate a = new calcDelegate(p.Add);
            a(10, 10); //or a.Invoke(10,10);

            calcDelegate s = new calcDelegate(p.Subtraction);
            s(10, 10);//or s.Invoke(10,10);

            //2. calling static method divide and multiply
            /*
             static method can be called directly from another static method
             */
            calcDelegate d = new calcDelegate(Divide);
            d(10, 10); //or d.Invoke(10,10);

            calcDelegate m = new calcDelegate(Multiply);
            m(10, 10); //or m.Invoke(10,10); 


        

            Console.ReadLine();

        }
    }
}
