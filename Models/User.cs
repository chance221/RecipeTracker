using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecipeTracker.Models
{
    public class User
    {
        
        [Key]
        public string UserID { get; set; }


        [Display(Name = "Last Name")]
        [Required]
        [StringLength(30, ErrorMessage="The last name cannot be more than 30 characters long")]
        public string LastName { get; set; }
        
        
        [Required]
        [StringLength(20, ErrorMessage = "The first name cannot be more than 20 characters long")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
        public string Email { get; set; }
        
        
        [Display(Name ="Recipes")]
        public virtual ICollection<Recipe> Recipes { get; set; }
        
        [NotMapped]
        [Display(Name = "FullName")]
        public virtual string FullName { get { return (FirstName + " " + LastName); } }

    }
}