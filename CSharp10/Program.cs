//top level statement
//implicit usings
//global usings

using static CSharp10Net6.ApiRoutes;

Console.WriteLine("Hello, World CSharp10Net6!");

var builder = new StringBuilder();

var x = Sin(Math.PI / 2.0);
Console.WriteLine(x);

static void SomeFunc()
{
    Console.WriteLine("Do something!");
}

SomeFunc();

//lambda improvements

//Func<string> SayHello = () => "Hello!";
var SayHello = () => "Hello!";

//Func<string?> text =  () => null;
var text = string? () => null;

//Action<int> act = x => Console.WriteLine(x);
var act = (int x) => Console.WriteLine(x);

//Func<int, IComparable> func = x => x < 0 ? 23 : "23";
var func = IComparable (int x) => x < 0 ? 23 : "23";


Console.WriteLine(SayHello());

Console.WriteLine(Library.GetById);