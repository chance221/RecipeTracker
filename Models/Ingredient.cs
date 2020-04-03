using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace RecipeTracker.Models
{
    public class Ingredient
    {
        [Required]
        public Guid IngredientID { get; set; }
        [Required]
        [MaxLength(45)]
        public string Name { get; set; }
        
        [Required]
        public double Quantity { get; set; }
        public bool InPantry { get; set; } = false;
        public Guid RecipeID { get; set; }
    }
}