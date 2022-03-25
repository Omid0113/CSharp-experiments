using CSharp9ClassLibraryNetStd2._1;
using System;

namespace CSharp9Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var p = new Person();
            //p.Age = 23;

            //when private set is used on a property,
            //values can not be assigned to Age property from outside like p.Age=23;
            //another constructor is needed to assign values

            //var p = new Person(23);

            var p = new Person() { Age = 23 };


            Console.WriteLine("Hello World CSharp9Net5!");
            Console.WriteLine($"{p.Age}");

            Person p1 = new Person();

            //implicit variable declaration
            //infer the type of left hand side by the type of right hand side
            var p2=new Person();

            //fit and finish
            //infer the type of right hand side by the type of left hand side
            Person p3 = new(); 

            Person p4 = new() { Age=23 };
           
            //new{} is the syntax for creating anonymous object
            //Person p4 = new{ Age = 23 };

        }
    }
}
