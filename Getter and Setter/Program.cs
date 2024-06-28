using System;


namespace getter_and_setter
{
    class Book
    {
        private int _id;
        private string _title;
        private int _noOfPages;

        public int ID   // property
        {
            get { return _id; }   // get method
            set { _id = value; }  // set method
        }

        public string Tittle   // property
        {
            get { return _title; }   // get method
            set   // set method
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("invalid tittle given");
                }
                else
                {
                    _title = value;
                }
            }
        }

        public int NoOfPages   // property
        {
            get { return _noOfPages; }   // get method
            set { _noOfPages = value; }  // set method
        }


        /* the above ID and NoOfPages property can also be written as
           
        public int ID   { get ; set }
        public int NoOfPages { get ; set } 

        as ID and NoOfPages do not have any conditions like tittle property has
        */
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b_obj = new Book();

            /*
             if the member variable id, titlle and noOfPages are created public (public int _id;
             public string _title;  public int _noOfPages;) then
             it can be accesed directly
             
            b_obj._id=0;
            b_obj.Title =NULL;
            b_obj.pages=1000;

            to avoid this are made as private 
            for accessing this private member vaiable getter  and setter method are required

            it can be done with properties. A property is like a combination of a variable and a 
            method, and it has two methods: a get and a set method:
             */


            b_obj.ID=1;
            b_obj.NoOfPages = 200;
            b_obj.Tittle = "The book ";
            Console.WriteLine(" book ID={0}\n NoOfPages={1}\n Tittle={2}", b_obj.ID, b_obj.NoOfPages, b_obj.Tittle);

            Book obj2 = new Book();
            Console.WriteLine("Enter book id");
            obj2.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NoOfPages of book ");
            obj2.NoOfPages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Tittle of book ");
            obj2.Tittle = Console.ReadLine();
            Console.WriteLine(" book ID={0}\n NoOfPages={1}\n Tittle={2}", obj2.ID, obj2.NoOfPages, obj2.Tittle);
            


            Console.ReadLine();
        }
    }
}
