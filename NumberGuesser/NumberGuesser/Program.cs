using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static int GetGuess()
        {
            Console.WriteLine("Please guess a number");
            string answer = Console.ReadLine();
            int guessNumber = 0;
            Int32.TryParse(answer, out guessNumber);

            return guessNumber;
        }

        static void Main(string[] args)
        {
            //string myString = "some value";
            //string anotherString = "other value";

            //bool result = myString == anotherString; //equal
            //bool equalResult = myString != anotherString; //not equal

            //int number1 = 5;
            //int number2 = 10;

            //bool number = number1 > number2;
            //bool equalBigNumber = number1 >= number2;
            int guessNumber = 0;
            const int ourNumber = 10;
            guessNumber = GetGuess();

            //========while loop==============
            //while (ourNumber != guessNumber)
            //{
            //    if (ourNumber == guessNumber)
            //    {
            //        Console.WriteLine("You guessed correctly. Well Done!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect. Please try again.");
            //        guessNumber = GetGuess();
            //    }
            //}

            //===========for loop==============
            //for (int n = 10; n > 0; n--)
            //{
            //    guessNumber = GetGuess();
            //    if (ourNumber == guessNumber)
            //    {
            //        Console.WriteLine("You guessed correctly. Well Done!");
            //        break;
            //    }
            //    else if (guessNumber > ourNumber)
            //        Console.WriteLine("Incorrect. You guessed too high, you have {0} guesses left.", n - 1);
            //    else
            //    {
            //        Console.WriteLine("Incorrect. You guessed too low, you have {0} guesses left.", n - 1);
            //    }
            //}

            //===========SWITCH STATEMENT==============
            for (int n = 10; n > 0; n--)
            {
                guessNumber = GetGuess();
                switch (guessNumber)
                {
                    case (ourNumber):
                        Console.WriteLine("You guessed correctly. Well Done!");
                        n = 0;
                        break;
                    case (1):
                        Console.WriteLine("That's way too low, you have {0} guesses left.", n - 1);
                        break;
                    case (100):
                        Console.WriteLine("That's way too high, you have {0} guesses left.", n - 1);
                        break;
                    default:
                        if (guessNumber > ourNumber)
                            Console.WriteLine("Incorrect. You guessed too high, you have {0} guesses left.", n - 1);
                        else
                        {
                            Console.WriteLine("Incorrect. You guessed too low, you have {0} guesses left.", n - 1);
                        }
                        break;
                }
            }

            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();

        }
    }
}
