using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.Bookstore
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
         
        }

        public Book()
        {
        }

        public string GetBookInfo()
        {
            return $"Title: {this.Title}, Author: {this.Author}, Price: ${this.Price}";
        }

    }
}
