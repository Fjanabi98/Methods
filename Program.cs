using MethodsExercise1;
using System.Drawing;

Console.WriteLine("what is your name");// input
var userName = Console.ReadLine();

Console.WriteLine($"Hi, {userName}. what is your favorite sport?");// input
var sport = Console.ReadLine();

Console.WriteLine("what is your favorite food?");//input 
var food = Console.ReadLine();

Console.WriteLine($"your favorite sport is{sport} your favorite food is{food}");

Console.WriteLine(Methods.Add(10,2));