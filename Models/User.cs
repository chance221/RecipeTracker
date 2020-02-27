﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipeTracker.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        public string Email { get; set; }
        [Display(Name ="Recipes")]
        public virtual ICollection<Recipe> Recipes { get; set; }
        [Display(Name = "FullName")]
        public virtual string FullName { get { return (FirstName + " " + LastName); } }

    }
}