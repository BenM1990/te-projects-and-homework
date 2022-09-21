using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {

			// ARRAYS

			double[] averageScores = new double[20];
			averageScores[0] = 3.0;

			//Lists lives in System.Collections.Generic;


			string[] teStaff = new string[6];
			teStaff[0] = "David";
			teStaff[1] = "Torl";
			teStaff[2] = "John";
			teStaff[3] = "Ben";
			teStaff[4] = "Kaitlin";
			teStaff[5] = "Chelsea";

			

			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<string> names = new List<string>(); // call constructor for list -> ()
			names.Add("Frodo");
			names.Add("Sam");
			names.Add("Pippin");
			names.Add("Merry");
			names.Add("Gandalf");
			names.Add("Aragorn");
			names.Add("Boromir");
			names.Add("Gimli");
			names.Add("Legolas");



			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			names.Add("Sam");

			for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			names.Insert(2, "David");

			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			names.RemoveAt(2);

			for (int i = 0; i < names.Count; i ++)
            {
                Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			bool isItemInList = names.Contains("Gandalf");

            Console.WriteLine("Is Gandalf in the names list? " + isItemInList);

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			

			//for(int i = 0; i < names.Count; i++)
			//{
			//	if (names[i] == "Gandalf") 
			//    {
			//		gandalfIndex = i;
			//    }
			//}

			//when item is not present in the collection and you ask for an index it'll return -1

			int gandalfIndex = names.IndexOf("Gandalf");

            Console.WriteLine("Gandalf is located at index " + gandalfIndex);

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] namesArray = names.ToArray();
			//forloop with namesArray and write to console.

			for (int i = 0; i < namesArray.Length; i++)
            {
				Console.WriteLine(namesArray[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			names.Sort(); // changes the list order
			for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			names.Reverse(); // changes the list order

			for(int i = 0; i < names.Count; i++)
            {
				Console.WriteLine(names[i]);
            }

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			//loop through names,
			//run the code block on every item in the collection
			//Explanation: foreach(type variableName in Collection)

			foreach(string lordOfTheRingsCharacter in names)
            {
                Console.WriteLine(lordOfTheRingsCharacter);
            }

			//Console.WriteLine("###### Foreach works on array too######")

			//string word = "Tech Elevator";
			
			//foreach( char letter in word)
            //{
            //   Console.WriteLine(letter);
            //}

            Console.WriteLine("###### Collections with Classes ########");
			
			List<Dog> dogs = new List<Dog>();
			
			Dog davidsDog = new Dog();
			davidsDog.Name = "Jerry";
			davidsDog.Age = 6;
			davidsDog.Breed = "Shepard-Mix";

			Dog zachDog = new Dog();
			zachDog.Name = "Rosy";
			zachDog.Age = 5;
			zachDog.Breed = "Pitbull";

			dogs.Add(zachDog);
			dogs.Add(davidsDog);

			foreach(Dog currentDog in dogs)
            {
                Console.WriteLine(currentDog.Name + ", is " + currentDog.Age + " years old, and a " + currentDog.Breed);
            }

			List<bool> isWeekend = new List<bool>();

			
			isWeekend.Add(false);

			isWeekend.Add(false);
			isWeekend.Add(false);
			isWeekend.Add(false);

			isWeekend.Add(true);
			isWeekend.Add(true);

			isWeekend.Add(false);

			foreach(bool dayOfWeek in isWeekend)
            {
                Console.WriteLine(dayOfWeek);
            }


			Console.WriteLine(" ##### Other Collections - Bonus ######");
			//QUEUE
			Queue<Dog> dogQueue = new Queue<Dog>();
			dogQueue.Enqueue(zachDog);
			dogQueue.Enqueue(davidsDog);

			dogQueue.Dequeue();

			//Stack
			Stack<Dog> dogStack = new Stack<Dog>();
			dogStack.Push(zachDog);
			dogStack.Push(davidsDog);

			Dog Jerry = dogStack.Pop();

			////LINKEDLIST
			


		}
	}
}
