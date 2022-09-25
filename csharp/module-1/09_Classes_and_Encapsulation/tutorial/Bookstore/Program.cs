using System;

namespace TechElevator.Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tech Elevator Bookstore");
            Console.WriteLine();

            // Step Three: Test the getters and setters
            Book twoCities = new Book();
            twoCities.Title = "A Tale of Two Cities";
            twoCities.Author = "Charles Dickens";
            twoCities.Price = 14.99M;
            Console.WriteLine(twoCities.GetBookInfo());

            // Step Five: Test the Book constructor

            Book threeMusketeers = new Book("The Three Musketeers", "Alexandre Dumas", 12.95M);
            Book childhoodEnd = new Book("Childhher's End", "Arthur C. Clark", 5.99M);

            Console.WriteLine(threeMusketeers.GetBookInfo());
            Console.WriteLine(childhoodEnd.GetBookInfo());

            // Step Nine: Test the ShoppingCart class

        }
    }
}
