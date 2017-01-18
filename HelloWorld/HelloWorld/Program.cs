using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myValue = "Stephan";

            //int number1 = 5;
            //int number2 = 10;
            //int sum = number1 + number2;

            //Console.WriteLine("Hello "+ myValue);
            //Console.WriteLine(number1 + " + " + number2 + " = " + sum);
            //Console.ReadLine();

            int num1 = 0;
            int num2 = 0;
            int answer = 0;

            Console.WriteLine("Enter a number: ");
            string sNum1 = Console.ReadLine();

            Console.WriteLine("Enter another number: ");
            string sNum2 = Console.ReadLine();

            Int32.TryParse(sNum1, out num1);
            Int32.TryParse(sNum2, out num2);

            answer = num1 + num2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + answer);

            Console.ReadLine();

        }
    }
}