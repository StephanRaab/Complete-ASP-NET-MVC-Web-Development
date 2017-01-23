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
            MyClassLibrary.MyObject myObject = new MyClassLibrary.MyObject();
            MySecondLibrary.MyObject myObject2 = new MySecondLibrary.MyObject(10, 10);
            myObject.Calculate(20, 52);

            com.squareconnection.mylibrary.MyObject object3 = new com.squareconnection.mylibrary.MyObject();

            //myobject.number1 = 10;
            //myobject.number2 = 5;

            //Console.WriteLine(myObject.number1 + " + " + myObject.number2 + " = " + myObject.Calculate());
            Console.WriteLine("object1 property is " + myObject.number3);
            Console.WriteLine("object2 property is " + myObject2.number3);
            Console.ReadLine();
        }
    }
}