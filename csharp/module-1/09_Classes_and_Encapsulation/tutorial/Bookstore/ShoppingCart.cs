using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.Bookstore
{
    public class ShoppingCart
    {
        private List<Book> booksToBuy = new List<Book>();

        public void Add(Book bookToAdd)
        {
            booksToBuy.Add(bookToAdd);
        }
    }

    
}
