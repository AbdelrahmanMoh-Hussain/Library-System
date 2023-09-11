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
        }

        public void SearchingForBookBy(string prefix)
        {
            bool nothingFound = true;
            foreach (var book in Books)
            {
                if (book.Name.StartsWith(prefix))
                {
                    nothingFound = false;
                    Console.WriteLine(book);
                }
            }
            if (nothingFound)
            {
                Console.WriteLine("Sorry Nothing Found");
            }
        }
        public void PrintBooksById()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }

        }
        public void PrintBooksByName()
        {
            List<Book> SortedList = Books.OrderBy(o => o.Name).ToList();
            foreach (var book in SortedList)
            {
                Console.WriteLine(book);
            }
        }

        public void PrintUsersBorrowed(string bookName)
        {
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
        }
    }
}
