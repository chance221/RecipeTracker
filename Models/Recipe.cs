using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace RecipeTracker.Models
{
    public enum CuisineType
    {
        African, American, Asian, Brazillian, British, Cajun, Chinese, Ethiopian, French, German, Grek, Indian, Italian, Jamaican, Japanese, Korean, Mediterranean, Mexican, MiddleEastern, Moroccan, Polish, Russian, SoulFood, Spanish, TexMex, Thai, Turkish, Vietnamese 
    }
    public class Recipe
    {
        public Guid RecipeID { get; set; }
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
        public string UserID { get; set; }
        public string? URL { get; set; }
        
        public int Rating { get; set; }
        public virtual ICollection<Direction> Directions { get; set; }
        public virtual ICollection<Ingredient> Ingrdients { get; set; }
    }
}