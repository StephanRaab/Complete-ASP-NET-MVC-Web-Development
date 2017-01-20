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
            MyObject myObject2 = new MyObject(10, 10);
            myObject.Calculate(20, 52);

            //myobject.number1 = 10;
            //myobject.number2 = 5;

            //Console.WriteLine(myObject.number1 + " + " + myObject.number2 + " = " + myObject.Calculate());
            Console.WriteLine("object1 property is " + myObject.number3);
            Console.WriteLine("object2 property is " + myObject2.number3);
            Console.ReadLine();
        }
    }
}