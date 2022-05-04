using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{


    struct Book
    {
        public string Name;
        private int Book_Id { get; set; }

        public int Book_ID
        {
            get { return Book_Id; }
            set { Book_Id = value; }
        }
        public void Display()
        {
            Console.WriteLine(" The Book id is:{0}", Book_Id);
            Console.WriteLine(" The Book name is:{1}", Name);
        }


    }
    class StructEg1
    {
        static void Main()
        {
            Book b = new Book();
            b.Book_ID = 111;
            b.Name = "Wings Of Fire";
            b.Display();
            Console.ReadLine();
        }

    }
}
    


