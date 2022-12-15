using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.Shared;

namespace PetElevator.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDue()
        {
            Customer customer = new Customer("Timothee", "Chalamet");

            Dictionary<string, double> servicesRendered = new Dictionary<string, double>()
            {
                {"Walking", 10.00 },
                {"Sitting", 5 },
                {"Grooming", 20},
            };
            double finalCost = customer.GetBalanceDue(servicesRendered);

            Assert.AreEqual(35, finalCost);



        }
    }
}
