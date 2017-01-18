using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    enum PetType
    {
        Dog,
        Duck
    }

    class PetClass
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    struct PetStruct
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    class Program
    {
        static void MultiplyLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine("(Internal method) - A " + petStruct.Type + " has " + petStruct.Legs);
            Console.WriteLine("(Internal method) - A " + petClass.Type + " has " + petClass.Legs);
        }

        static void Main(string[] args)
        {
            // ************ LESSON 1 *************
            //string myValue = "Stephan";

            //int number1 = 5;
            //int number2 = 10;
            //int sum = number1 + number2;

            //Console.WriteLine("Hello "+ myValue);
            //Console.WriteLine(number1 + " + " + number2 + " = " + sum);
            //Console.ReadLine();

            //int num1 = 0;
            //int num2 = 0;
            //int answer = 0;

            //Console.WriteLine("Enter a number: ");
            //string sNum1 = Console.ReadLine();

            //Console.WriteLine("Enter another number: ");
            //string sNum2 = Console.ReadLine();

            //Int32.TryParse(sNum1, out num1);
            //Int32.TryParse(sNum2, out num2);

            //answer = num1 + num2;

            //Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + answer);

            //Console.ReadLine();

            //********* LESSON 2 ******************
            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.Legs = 4;
            dog.HasFur = true;
            Console.WriteLine("A " + dog.Type + " has " + dog.Legs + " legs.");

            PetClass duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.Legs = 2;
            duck.HasFur = false;
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs + " legs.");

            //MultiplyLegs(dog, duck);
            //Console.WriteLine("A " + dog.Type + " has " + dog.Legs);
            //Console.WriteLine("A " + duck.Type + " has " + duck.Legs);

            PetStruct copiedDog = dog;
            PetClass copiedDuck = duck;

            copiedDog.Legs = copiedDog.Legs * 2;
            copiedDuck.Legs = copiedDuck.Legs * 2;

            Console.WriteLine("A " + dog.Type + " has " + dog.Legs);
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs);

            Console.WriteLine("A " + copiedDog.Type + " has " + copiedDog.Legs);
            Console.WriteLine("A " + copiedDuck.Type + " has " + copiedDuck.Legs);

            Console.ReadLine();

        }
    }
}