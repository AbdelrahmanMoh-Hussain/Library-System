using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class Admin
    {
        private List<Book> books;
        private List<User> users;

        public Admin()
        {
            books = new List<Book>();
            users = new List<User>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book Added Successfully");
        }

        public void SearchingForBookBy(string prefix)
        {
            bool nothingFound = true;
            foreach (var book in books)
            {
                if (book.Name.StartsWith(prefix))
                {
                    nothingFound = false;
                    Console.WriteLine(book);
                }
            }
            if(nothingFound)
            {
                Console.WriteLine("Sorry Nothing Found");
            }
        }

        public void PrintBooksById()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

        }
        public void PrintBooksByName()
        {
            List<Book> SortedList = books.OrderBy(o => o.Name).ToList();
            foreach (var book in SortedList)
            {
                Console.WriteLine(book);
            }
        }
        public void PrintUsersBorrowed(string bookName)
        {
            foreach (var b in books) 
            {
                if(b.Name == bookName)
                {
                    foreach(var user in b.UsersBorrowed) 
                    {
                        Console.WriteLine(user);
                    }
                    break;
                }
            }
        }


        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine("User Added Successfully");
        }

        public void UserBorroweBook(string userName, string bookName)
        {
            User user = null;
            foreach(var u in users)
            {
                if(u.Name == userName)
                {
                    user = u;
                    break;
                }
            }
            foreach(var b in books)
            {
                if(b.Name == bookName)
                {
                    if(b.Quantity > 0)
                    {
                        b.UsersBorrowed.Add(user);
                        b.Quantity--;
                        Console.WriteLine($"User {userName} borrowed {bookName} book, this book available quantity = {b.Quantity}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"There is no enough copies of this book: {bookName} to borrowe");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
            }
        }

        public void UserReturnBook(string userName, string bookName)
        {
            User user = null;
            foreach (var u in users)
            {
                if (u.Name == userName)
                {
                    user = u;
                    break;
                }
            }
            foreach (var b in books)
            {
                if (b.Name == bookName)
                {
                    b.UsersBorrowed.Remove(user);
                    b.Quantity++;
                    Console.WriteLine($"User {userName} borrowed {bookName} book, this book available quantity = {b.Quantity}");
                }
            }
        }

        public void PrintUsers()
        {
            if(users.Count == 0)
            {
                Console.WriteLine("There is no Users in the system until now!!");
                return;
            }
            foreach(var user in users)
            {
                Console.WriteLine(user);
            }
        }


    }
}
