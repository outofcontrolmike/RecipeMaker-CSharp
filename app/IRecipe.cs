using System;

namespace MyApp
{
    //Interface for Recipe and types

    interface IRecipe
    {
          string Name { get; }
          
          int Servings {get;}

          string Category {get;}

          string Subcategory {get;}

          int PrepTime {get;}

          int CookTime {get;}

          string Directions {get;}

          string Ingredients {get;}

          string Author {get;}
    }
}