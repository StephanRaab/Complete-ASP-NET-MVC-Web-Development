using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject();

            //myObject.number1 = 10;
            //myObject.number2 = 5;

            //Console.WriteLine(myObject.number1 + " + " + myObject.number2 + " = " + myObject.Calculate());
            Console.WriteLine("The calculation is " + myObject.Calculate(70,7));
            Console.ReadLine();
        }
    }

    class MyObject
    {
        //public string MyStringProperty { get; set; } //'get-set' allows us to assign or get a string value from this property
        //void VoidedMethod(string input, int value) { } //if you don't want your method to return anything, USE VOID
        //public string MyMethod()
        //{
        //    return "some value";
        //}

        //public int number1 { get; set; }
        //public int number2 { get; set; }

        public int Calculate(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}