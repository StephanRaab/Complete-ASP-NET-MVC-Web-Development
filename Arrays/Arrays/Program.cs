using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Dog
    {
        public int Id { get; set }
        public string Name { get; set; }
        public int Legs { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            string[] stringArray = new string[5];

            int[] populatedIntArray = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            string[] populatedStringArray = new string[] { "one", "two", "three" };

            intArray[0] = 5;
            intArray[2] = 15;

            int firstValue = intArray[0];

            //2 rows with three columns
            int[,] multiInt = new int[2, 3];
            int[,] multiIntWithContext = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("Row 0: " + multiIntWithContext[0, 0] + " " + multiIntWithContext[0, 1] + " " + multiIntWithContext[0, 2]);
            Console.WriteLine("Row 1: " + multiIntWithContext[1, 0] + " " + multiIntWithContext[1, 1] + " " + multiIntWithContext[1, 2]);
            

            Dog[] dogArray = new Dog[2];
            dogArray[0] = new Dog() { Name = "Rover" };

            //more flexible
            List<string> strings = new List<string>();
            strings.Add("My first string");
            strings.Add("Another string");
            strings.Add("Yet another string");

            strings.Insert(0, "inserting at the beginning");
            strings.Remove("another"); //searches through the strings for "another" and will remove it
            strings.RemoveAt(1); //will remove at index[1]
            strings.Sort(); //self explanatory

            //similar to list<T>
            //james, money, aristotle = key
            //bond, penny, kristatos = actual data
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("James", "Bond");
            names.Add("Money", "Penny");
            names.Add("Aristotle", "Kristatos");

            Console.WriteLine(names["Aristotle"]);

            names.Remove("Money");

            List<Dog> dogs = new List<Dog>() {
                new Dog() { Id = 1, Name = "Baxter", Legs = 3 },
                new Dog() {Id = 2, Name = "Fido", Legs = 4 },
                new Dog() { Id = 3, Name = "Jack", Legs = 4 }
            };

            //Linq query = searching a list for a particular element based off of what you want to search on.
            //linQ returns an ienumerable
            List<Dog> results = (from d in dogs
                                where d.Name == "Baxter"
                                select d).ToList(); //converts ienumerable to a list

            //LinQ Lamda Method ("where" method to be specific)
            results = dogs.Where(d => d.Name == "Fido").ToList();

            //with var keyword we don't have to convert to a list
            var varResults = from d in dogs
                             where d.Name == "Jack"
                             select d;

            //Return single element/item from that list
            Dog dogFound = (from d in dogs
                                 where d.Id == 1
                                 select d).FirstOrDefault();

            dogFound = dogs.FirstOrDefault(d => d.Name == "Baker");

            Console.ReadLine();
        }
    }
}