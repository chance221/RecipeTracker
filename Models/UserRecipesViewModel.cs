using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeTracker.Models
{
    public class UserRecipesViewModel

    {
        public User User { get; set; }
        public string UserFullName { get; set; }
        public List<Recipe> Recipes { get; set; }
        public List<Ingredient> RecipeIngredients { get; set; }
        public List<Direction> RecipeDirection { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
    }
}