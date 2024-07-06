using System;
/* 
 3. if return type is non void of the method then multicast delegate will have value of last most call
 */

namespace MultiCast_Delegate
{
        public delegate int calcDelegate(int a, int b);
     class returnType
    {
      
            public int Add(int x, int y)
            {
                Console.WriteLine("Add function executed and value returned is {0} ", x + y);
                return x+y;
            }
            public int Subtraction(int x, int y)
            {
                Console.WriteLine("Subtraction function executed and value returned is {0} ", x - y);
                return x-y;
            }

        static void Main(string[] args)
        {

            returnType r=new returnType();

            calcDelegate c = new calcDelegate(r.Add);
            c += r.Subtraction;

            int result = c(1, 2);   //-1
            Console.WriteLine(" result={0} ", result);

            /*
              here the result has value =-1 (1-2=-1) in it because 
              When a multicast delegate is invoked, it executes each method in its invocation
              list in sequence. However, only the return value of the last method in the sequence is returned to the caller.
               */


            Console.ReadLine();

        }


    }
}
