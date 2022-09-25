using System;
using EncapsulationLecture.Classes;

namespace EncapsulationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person david = new Person(1989);
            string dogName = "Jerry";

            Dog davidsDog = new Dog(dogName, "Shepard-Mix", false);
            Dog charliesDog = new Dog("Snoopy", "Beagle", false);
            davidsDog.SpeakSound = "Ruff!";
            //calling Speak on davids dog.
            davidsDog.Speak();


            charliesDog.SpeakSound = "aarf";
            //Calling speak on charlies dog
            charliesDog.Speak();

            charliesDog.Speak("grrrrrr");

            charliesDog.Speak(6);

            string charliesDogGreeting = charliesDog.GetGreeting();

            Console.WriteLine(charliesDogGreeting);
        }
    }
}
