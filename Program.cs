using System;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear user"!);
            Console.WriteLine("We welcome you on our Ridewald books library.");
            Console.WriteLine("Look at a avalible book list and register to become a part of our books lover family!");
            User a = new User();
            a.PersonalNum();
            a.PersonalData();
            
            Library b = new Library();
            b.Book();
            b.ChooseBook();

            OrderBy c = new OrderBy();
            c.Order();
           
            
            

            Console.ReadKey();
        }
    }
    class Library
    {
        int count;
        public static string Choose;
        public void Book()
        {
            string[] bookname = { "Harry Potter", "Sherlock Holmes", "Inferno" };
            foreach (var book in bookname)
            {
                Console.WriteLine(book);
            }

        }
        
        public void ChooseBook()
        {
            Console.WriteLine("From list of availible book, please choose your order!");
            Console.WriteLine("\n Enter: A, B, C");
            Choose = Console.ReadLine();

            switch (Choose)
            {
                case "A":
                    Console.WriteLine("Harry Potter");
                    break;
                case "B":
                    Console.WriteLine("Sherlock Holmes");
                    break;
                case "C":
                    Console.WriteLine("Inferno");
                    break;
                default:
                    Console.WriteLine("Error#345123; Choose book to order from avaliable list!");
                    break;
            }

        }

    }
    class User
    {
        public static string name;
        public static int PersonalNumber;


        public void PersonalNum()
        {
            Random rnd = new Random();
            PersonalNumber = rnd.Next();
        }

        public void PersonalData()
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello dear {name} this is your personal number: {PersonalNumber}");

        }
    }

    class OrderBy
    {
        public void Order()
        {
            Console.WriteLine("Your final order is: ");
            Console.WriteLine($"Login: {User.name} with personal number {User.PersonalNumber} choosed {Library.Choose}");

        }



    }
}



