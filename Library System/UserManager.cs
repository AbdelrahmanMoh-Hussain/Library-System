using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_System
{
    internal class UserManager
    {
        public List<User> Users { get; } = new List<User>();

        public void AddUser(User user)
        {
            Users.Add(user);
            Console.WriteLine("User Added Successfully");
            Console.WriteLine("--------------------");
        }

        public void PrintUsers()
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("There is no Users in the system until now!!");
                return;
            }
            foreach (var user in Users)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("--------------------");
        }
    }
}
