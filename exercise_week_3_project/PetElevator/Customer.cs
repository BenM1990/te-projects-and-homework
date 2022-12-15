using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.Shared;

namespace PetElevator
{
    public class Customer : Person, IBillable
    {
        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            this.PhoneNumber = phoneNumber;
        }

        public Customer(string firstName, string lastName) : this(firstName, lastName, "")
        {

        }

        public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double output = 0;
            foreach(KeyValuePair<string, double> service in servicesRendered)
            {
                output += service.Value;
            }
            return output;
        }


    }
}
