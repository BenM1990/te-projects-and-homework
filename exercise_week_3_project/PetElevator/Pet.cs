using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.Shared;


namespace PetElevator
{
    public class Pet
    {
        public string PetName { get; set; }
        public string Species { get; set; }
        public List<String> Vaccinations { get; set; } = new List<String>();
        public Pet(string petName, string species) 
        {
            this.PetName = petName;
            this.Species = species;
        }

        public void ListVaccinations()
        {
            List<string> Vaccinations = new List<string>();
            Vaccinations.Add("Rabies");
            Vaccinations.Add("Distemper");
            Vaccinations.Add("Parvo");

        }



    }
}
