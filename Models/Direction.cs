using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeTracker.Models
{
    public class Direction
    {
        public Guid DirectionID { get; set; }
        public int StepNum { get; set; }
        public string Instruction { get; set; }
        public virtual Guid RecipeID { get; set; }

    }
}