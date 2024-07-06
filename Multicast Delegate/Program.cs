using System;
/*
1. multicaast delegate is a concept in which we can use one delegate to call all the method with same signature
eg 

 calcDelegate c = new calcDelegate(p.Add);  //this delegate has refrence of add function in it
 
now we need to do binding of it 
c += p.Subtraction;

now this delegate points to add as well as substract funtion 

now to pass value 
c(1,2);
this we execute both add and substraction function and pass 1 and 2 as parameter 
    */

namespace MultiCast_Delegate
{
        public delegate void calcDelegate(int a, int b);
        class Program
        {
         
            public void Add(int x, int y)
            {
                Console.WriteLine("add={0}", x + y);
            }
            public void Subtraction(int x, int y)
            {
                Console.WriteLine("Subtraction={0}", x - y);
            }

         

            static void Main(string[] args)
            {

                Program p = new Program();

                calcDelegate c = new calcDelegate(p.Add);

                 c += p.Subtraction;

            Console.WriteLine("passing value 1 and 2 as parameters");
             c(1,2);

            Console.WriteLine("passing value 3 and 4 as parameters");
            c(3, 4);


            /*
             2. If the return type is void then the behaviour is different 
               refer . returnType.cs
             
            */


            Console.ReadLine();

            }
        }
    
}
