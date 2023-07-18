namespace Library_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();   
            do
            {
                printMenu();
                var key = Console.ReadLine();
                if(key == "1")
                {
                    Console.WriteLine("Enter book info: ");
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Quantity: ");
                    var quanitiy = Console.ReadLine();
                    Book book = new Book(name, int.Parse(quanitiy));
                    admin.AddBook(book);
                }
                else if (key == "2")
                {
                    Console.WriteLine("Enter search info: ");
                    Console.Write("Prefix to search by: ");
                    var prefix = Console.ReadLine();
                    admin.SearchingForBookBy(prefix);
                    Console.WriteLine("--------------------");
                }
                else if (key == "3")
                {
                    Console.Write("Enter book name:");
                    var bookName = Console.ReadLine();
                    admin.PrintUsersBorrowed(bookName);
                    Console.WriteLine("--------------------");
                }
                else if (key == "4")
                {
                    admin.PrintBooksById();
                    Console.WriteLine("--------------------");
                }
                else if (key == "5")
                {
                    admin.PrintBooksByName();
                    Console.WriteLine("--------------------");
                }
                else if (key == "6")
                {
                    Console.WriteLine("Enter User info: ");
                    Console.Write("Id: ");
                    var id = Console.ReadLine();
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    User user = new User(int.Parse(id), name);
                    admin.AddUser(user);
                }
                else if (key == "7")
                {
                    Console.WriteLine("Enter user name & book name:");
                    var userName = Console.ReadLine();
                    var bookName = Console.ReadLine();
                    admin.UserBorroweBook(userName, bookName);
                }
                else if (key == "8")
                {
                    Console.WriteLine("Enter user name & book name:");
                    var userName = Console.ReadLine();
                    var bookName = Console.ReadLine();
                    admin.UserReturnBook(userName, bookName);
                }
                else if (key == "9")
                {
                    admin.PrintUsers();
                    Console.WriteLine("--------------------");
                }
                else if (key == "10")
                {
                    Console.WriteLine("GoodBye!!");
                    break;
                }
            } while (true);
        }
        static void printMenu()
        {
            Console.WriteLine("Library Menu: ");
            Console.WriteLine("1.  Add book");
            Console.WriteLine("2.  Searching For Book By Prefix");
            Console.WriteLine("3.  Print Users Borrowed Books");
            Console.WriteLine("4.  Print Books By Id");
            Console.WriteLine("5.  Print Books By Name");
            Console.WriteLine("6.  Add User");
            Console.WriteLine("7.  User Borrowe Book");
            Console.WriteLine("8.  User Return Book");
            Console.WriteLine("9.  Print users");
            Console.WriteLine("10. Exit");
            Console.WriteLine("Enter menu choice [1 - 10]");
        }
    }

}