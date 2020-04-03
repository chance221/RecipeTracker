using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipeTracker.Models
{
    public class Direction
    {
        [Required]
        public Guid DirectionID { get; set; }
        
        [Required]
        public int StepNum { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(5)]
        public string Instruction { get; set; }
        
        public virtual Guid RecipeID { get; set; }

    }
}