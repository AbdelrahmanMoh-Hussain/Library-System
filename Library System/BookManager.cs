using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_System
{
    internal class BookManager
    {
        public List<Book> Books { get; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book Added Successfully"); 
            Console.WriteLine("--------------------");
        }

        public void SearchingForBookBy(string prefix)
        {
            bool nothingFound = true;
            foreach (var book in Books)
            {
                if (book.Name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    nothingFound = false;
                    Console.WriteLine(book);
                }
            }
            if (nothingFound)
            {
                Console.WriteLine("Sorry Nothing Found");
            }
            Console.WriteLine("--------------------");
        }
        public void PrintBooksById()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("There is no Books in the system until now!!");
                return;
            }
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("--------------------");

        }
        public void PrintBooksByName()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("There is no Books in the system until now!!");
                return;
            }
            List<Book> SortedList = Books.OrderBy(o => o.Name).ToList();
            foreach (var book in SortedList)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("--------------------");
        }

        public void PrintUsersBorrowed(string bookName)
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("There is no Books in the system until now!!");
                return;
            }
            foreach (var b in Books)
            {
                if (b.Name == bookName)
                {
                    foreach (var user in b.UsersBorrowed)
                    {
                        Console.WriteLine(user);
                    }
                    break;
                }
            }
            Console.WriteLine("--------------------");
        }
    }
}
