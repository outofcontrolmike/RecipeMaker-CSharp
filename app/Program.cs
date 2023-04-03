// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There! Welcome to the Recipes Terminal Project!");
           
            Recipe r = new Recipe();

            r.Name = AskQuestions();
            // Recipe r = new Recipe
            // ("Chorizo Tacos", 4, "Mexican", "Tacos", 15, 20, "Delicious Mexican Food", "test", "Carlos");
            
            // Console.WriteLine(r);
            Console.WriteLine(r.Name);
        

        }

        static string AskQuestions()
        {
            Console.WriteLine("What would you like to name the recipe? ");
            string name = Console.ReadLine();
            Console.WriteLine($"You decided to name your recipe: {name}");
            return name;
        }
    }
}