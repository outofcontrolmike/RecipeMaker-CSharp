// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 5 Recipe objects to use
            Recipe r = new Recipe();
            Breakfast br = new Breakfast();
            Lunch lr = new Lunch();
            Dinner dr = new Dinner();
            Snack sr = new Snack();

            Introduction();
            string rType =  RecipeType();

            //Todo: Figure out a better way to actually pass an object instead of its props
            if(rType == "Unknown")
            {
                assignProps(r.Name,r.Servings,r.Category,r.Subcategory,r.PrepTime,r.CookTime,r.Directions,r.Ingredients,r.Author);          
            }

            if(rType == "Breakfast")
            {
                assignProps(br.Name,br.Servings,br.Category,br.Subcategory,br.PrepTime,br.CookTime,br.Directions,br.Ingredients,br.Author);
            }

            if(rType == "Lunch")
            {
                assignProps(lr.Name,lr.Servings,lr.Category,lr.Subcategory,lr.PrepTime,lr.CookTime,lr.Directions,lr.Ingredients,lr.Author);
            }
            
             if(rType == "Dinner")
            {
                assignProps(dr.Name,dr.Servings,dr.Category,dr.Subcategory,dr.PrepTime,dr.CookTime,dr.Directions,dr.Ingredients,dr.Author);
            }

             if(rType == "Snack")
            {
                assignProps(sr.Name,sr.Servings,sr.Category,sr.Subcategory,sr.PrepTime,sr.CookTime,sr.Directions,sr.Ingredients,sr.Author);
            }
        }


//Helper function for setting up dynamic objects
static private void assignProps(string name, int servings, string category, string subCategory, int prepTime, int cookTime, string directions, string ingredients, string author )

{
    name = RecipeName();
    servings = Servings();
    category = Category(true);
    subCategory = Category(false);
    prepTime = PrepTime();
    cookTime = CookTime();
    directions = Directions();
    ingredients = Ingredients();
    author = AuthorName();
}
        static private void Introduction()
        {
            Console.WriteLine("Hello There! Welcome to the Recipes Terminal Project!"  + "\nPlease press any key to continue:");
            Console.ReadKey();
            Console.Clear();
        }
        
        //Ask for Recipe Type
        static private string RecipeType()
        {
             Console.WriteLine("What Type of Recipe would you like to create?");
            
            Console.WriteLine("Please enter a corresponding key for the type of recipe you'd like to create:\n" + 
            "1: Breakfast\n2: Lunch\n3: Dinner\n4: Snack");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": 
                choice = "Breakfast";
                break;
                case "2": 
                choice = "Lunch";
                break;
                case "3": 
                choice = "Dinner";
                break;
                case "4": 
                choice = "Snack";
                break;
                default:
                choice = "Unknown";
                break;
            }
            Console.WriteLine($"You chose to create a {choice} type of Recipe\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
            return choice;
        }
        //Get User input for Recipe Name
        static private string RecipeName()
        {
            string name = "";
            do{
            Console.WriteLine("What would you like to name the recipe? ");
            name = Console.ReadLine();
            } while (name == "");
            Console.WriteLine($"You decided to name your recipe: {name}");
            return name;
        }
        
        static private int Servings()
        {
            Console.WriteLine("Please enter the amount of servings that your recipe will make: ");
            int servings = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            return servings;
        }

        static private int PrepTime()
        {
                 Console.WriteLine("Please enter how many minutes this recipe takes to Prep: ");
            int prepTime = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            return prepTime;
        }

          static private int CookTime()
        {
                 Console.WriteLine("Please enter how many minutes this recipe takes to Cook: ");
            int cookTime = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            return cookTime;
        }
        
         static private string Ingredients()
        {
            Console.WriteLine("Please list out the Ingredients.. for now our program will separate the directions based on where you place commas in your text. ");
            
            string ingredients = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
            return ingredients;

        }

        static private string Directions()
        {
            Console.WriteLine("Please list out the directions.. for now our program will separate the directions based on where you place periods in your text. ");
            
            string directions = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
            return directions;

        }

        static private string AuthorName()
        {
            Console.WriteLine("Please enter your name or the authors name... it's fine if you want to use first and last: ");

            string author = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
            return author;
        }

        static private string Category(bool isCategory)
        {
            string cat = "";
            if(isCategory == true)
            {
                cat = "Category";
            }
            else {
                cat = "Sub Category";
            }
            Console.WriteLine($"What would you say the {cat} is for your recipe?: ");
            string category = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
            return category;
        }
        //Determine which object to create
        // static object RecipeObject(object recipeClass)
        // {
        //     Console.WriteLine(recipeClass);
        //      if(recipeClass == "Breakfast")
        //      {
        //     Breakfast r = new Breakfast();
        //     }
        //     if(recipeClass == "Dinner")
        //      {
        //     Dinner r = new Dinner();
        //     }
        //     if(recipeClass == "Lunch")
        //      {
        //     Lunch r = new Lunch();
              
        //     }
        //     if(recipeClass == "Snack")
        //      {
        //     Snack r = new Snack();
        //     }
        //     else {
        //         Recipe r = new Recipe();
        //     } 
          
        // }
     
    }
}