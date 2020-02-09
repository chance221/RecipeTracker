using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeTracker.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }

    }
}