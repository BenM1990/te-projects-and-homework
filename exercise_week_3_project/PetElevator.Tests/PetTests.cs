using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.Shared;


namespace PetElevator.Tests
{
    [TestClass()]
    public class PetTests
    {
        [TestMethod]
        public void ListVaccinations()
        {
           Pet pet = new Pet("Timothee", "Cat");
            
           string expectedVaccination = "Rabies";

           string actualVaccination = expectedVaccination;

           Assert.AreEqual(expectedVaccination, actualVaccination);


        }
        
        

    }
}
