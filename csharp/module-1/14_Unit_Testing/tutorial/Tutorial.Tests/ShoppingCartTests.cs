using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TechElevator.Bookstore;

namespace Tutorial.Tests
{
    [TestClass]
            public class ShoppingCartTests
    {

            [TestMethod]
            public void Subtotal_ValidItems_EqualsSumOfAllItems()
            {
                //Arrange - Creat a shopping cart with items

                //Creat a shopping cart and add both taxable and non-taxable items to it.
                ShoppingCart cart = new ShoppingCart(0.10); // 10% tax rate

                // Taxable $10 plus $1 tax
                cart.Add(new Book("Dynamics of Software Development", "Jim McCarthy", 10.00M));

                // Taxable $20 plus $2 tax
                cart.Add(new Movie("Free Guy", "PG-13", 115, 20.00M));

                //Not taxable $10
                cart.Add(new Coffee("Jumbo", "Bold", new string[] { "cream" }, 10.00M));

                //Act - get the subtotal
                decimal subtotal = cart.SubtotalPrice;

                //Assert - make sure value is correct
                Assert.AreEqual(40.00M, subtotal);
            }
      }
}

