using System;

namespace CSharp8NetCore3._1NullableReferences
{
    internal class Program
    {
        //nullable reference types means that all objects are non-nullable and 
        //by adding a ? in front of the type keyword, it is decalred as nullable
        //object so safety code need to be added for these nullable objects 
        //to avoid null reference exceptions
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World CSharp8NetCore3.1!");

            MotorCar car = new MotorCar(new Person("Richard"),
                                       new Engine { Capacity = 1600 });

            Console.WriteLine(car);
        }
    }
}
