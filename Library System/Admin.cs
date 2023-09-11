using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_System
{
    internal class Admin
    {
        public BookManager BookManager { get; } = new BookManager();
        public UserManager UserManager { get; } = new UserManager();

        public void UserBorroweBook(string userName, string bookName)
        {
            User user = null;
            foreach (var u in UserManager.Users)
            {
                if (u.Name == userName)
                {
                    user = u;
                    break;
                }
            }
            foreach (var b in BookManager.Books)
            {
                if (b.Name == bookName)
                {
                    if (b.Quantity > 0)
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
            foreach (var u in UserManager.Users)
            {
                if (u.Name == userName)
                {
                    user = u;
                    break;
                }
            }
            foreach (var b in BookManager.Books)
            {
                if (b.Name == bookName)
                {
                    b.UsersBorrowed.Remove(user);
                    b.Quantity++;
                    Console.WriteLine($"User {userName} borrowed {bookName} book, this book available quantity = {b.Quantity}");
                }
            }
        }





    }
}
