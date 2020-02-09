using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace RecipeTracker.Models
{
    public class Ingredient
    {
        public Guid IngredientID { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public bool InPantry { get; set; } = false;
        public Guid RecipeID { get; set; }
    }
}