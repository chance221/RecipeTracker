using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RecipeTracker.DAL;
using RecipeTracker.Models;

namespace RecipeTracker.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private RecipeTrackerContext db = new RecipeTrackerContext();
        UserRecipesViewModel _userRecipeData = new UserRecipesViewModel();

        // GET: Recipe
        [AllowAnonymous]
        public ActionResult Index()
        {
            var recipes = db.Recipes.ToList();
           
            return View(recipes);
        }

        // GET: Recipe/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // GET: Recipe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecipeID,Name,CuisineType,UserID,URL,Rating")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                recipe.RecipeID = Guid.NewGuid();
                db.Recipes.Add(recipe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recipe);
        }

        // GET: Recipe/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // POST: Recipe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecipeID,Name,CuisineType,UserID,URL,Rating")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recipe);
        }

        // GET: Recipe/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // POST: Recipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Recipe recipe = db.Recipes.Find(id);
            db.Recipes.Remove(recipe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult EditDisplay()
        {
            var users = db.Users.ToList();

            return View("ListAllUsers", users);
        }


        public ActionResult ListAllUsers()
        {
            List<User> users = db.Users.ToList();
            
            return View(users);
        }

        //This is the custom view for EditDisplay
        public ActionResult ListUserRecipes(string userId)
        {
            var recipes = new List<Recipe>();
          
                try
                {
                    
                    if (userId == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    
                    User user = db.Users.Find(userId);

                    
                    recipes = db.Recipes.Where(r => r.UserID == userId).ToList();

                }
                catch
                {
                    _userRecipeData.ErrorMessage = "Hmmmm something wwent wrong, couldn't locate that user.";
                    //have the option to reload the page? or redirect back to a different page
                    
                }
                return View(recipes);
        }

            

        //This is the post for the EditDisplay
        [HttpPost]
        public ActionResult GetAllRecipeData(string userId) 
        {
            ICollection<Direction> directions = new List<Direction>();
            ICollection<Ingredient> ingredients = new List<Ingredient>();
            UserRecipesViewModel vm = new UserRecipesViewModel();
            User user = db.Users.Where(u => u.UserID == userId).FirstOrDefault();
            
            var ingredientsList = new List<Ingredient>();
            //this needs to be sorted and filtered in the view using razor syntax
            
            var directionsList = new List<Direction>();
            //this needs to be sorted and filtered in the view using razor syntax

            vm.User = user;

            var recipes = db.Recipes.Where(r => r.UserID == userId).ToList();
            
            foreach (Recipe recipe in recipes)
            {
                ingredientsList.AddRange(db.Ingredients.Where(i => i.RecipeID == recipe.RecipeID));
                directionsList.AddRange(db.Directions.Where(d => d.RecipeID == recipe.RecipeID));
            }
            directionsList.OrderBy(d => d.StepNum);
            
            vm.User.Recipes = recipes;
            vm.RecipeDirection = directionsList;
            vm.RecipeIngredients = ingredientsList;

            return View("ListUserRecipes", vm);
        }
    }
}
