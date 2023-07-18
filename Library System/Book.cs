using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class Book
    {
        public static int BooksIdCounter = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public List<User> UsersBorrowed { get; set; }

        public Book(string name, int quantity)
        {
            Id = BooksIdCounter++;
            Name = name;
            Quantity = quantity;
            UsersBorrowed = new List<User>();
        }

        public override string ToString()
        {
            return  $"Id: {Id}" +
                    $"\tName: {Name}" +
                    $"\tQuantity: {Quantity}";
        }

    }
}
