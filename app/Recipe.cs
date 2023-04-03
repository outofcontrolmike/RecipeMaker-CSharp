//This should be a super class that different types of recipes can inherit from
using System;

namespace MyApp
{


class Recipe : IRecipe
{
    //Fields
 
    public string name;
    public int servings;
    public string category;
    public string subcategory;
    public int prepTime;
    public int cookTime;
    public string directions;
    public string ingredients;
    public string author;

    // //Constructor
    // public Recipe(string name = null, int servings = 0, string category = null, string subcategory = null,
    // int prepTime = 0, int cookTime = 0, string description = null, string ingredients = null, string author = null)
    // {

    //     this.Name = name;
    //     this.Servings = servings;
    //     this.Category = category;
    //     this.Subcategory = subcategory;
    //     this.PrepTime = prepTime;
    //     this.CookTime = cookTime;
    //     this.Description = description;
    //     this.Ingredients = ingredients;
    //     this.Author = author;
    // }

    public Recipe()
    {
        
    }

    // public Recipe(string name) : this(name, "Unknown")
    // {

    // }
    
    //Props - getters & setters
    public string Name {
        get; set;
    }

    public int Servings {
        get; set;
    }
    public string Category {
        get; set;
    }
    public string Subcategory {
        get; set;
    }
    public int PrepTime {
        get; set;
    }

    public int CookTime {
        get; set;
    }

    public string Directions{
        get; set;
    }
    public string Ingredients {
        get; set;
    }
    public string Author {
        get; set;
    }

    //Methods - Maybe print description?
    // public int IncreaseServings()
    // {

    // }
}

}