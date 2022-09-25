using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.Classes
{
    class Person
    {
        //Public PascalCase
        //private camalCase

        //name
        public string Name { get; set; }
        //age
        //based on the birthyear compared to the current date
        public int Age { 

            //Derived property. - only get = readonly.
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - birthYear;
            }
        }
        private int birthYear { get; set; }
        //height
        public double Height { get; set; }
        //SSN
        private string ssn { get; set; }

        //Constructor
        //Once a constructor is defined, the default no-argument constructor is not available.
        public Person(int yearOfBirth)
        {

        }

        
    }
}
