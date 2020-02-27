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
    public class RecipeController : Controller
    {
        private RecipeTrackerContext db = new RecipeTrackerContext();
        UserRecipesViewModel _userRecipeData = new UserRecipesViewModel();

        // GET: Recipe
        public ActionResult Index()
        {
            return View(db.Recipes.ToList());
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

        public ActionResult ListAllUsers()
        {
            List<User> users = db.Users.ToList();
            //List<UserRecipesViewModel> VmList = new List<UserRecipesViewModel>();
            
            //UserRecipesViewModel person = new UserRecipesViewModel();
            //foreach(var user in users)
            //{
            //    person.UserFullName = user.FirstName + " " + user.LastName;
            //    person.UserRecipes = user.Recipes.ToList();
            //    VmList.Add(person);
            //}
            
            return View(users);

        }


        public ActionResult ListUserRecipes(Guid userId)
        {
            User user = db.Users.Find(userId);

            _userRecipeData.User = user;

            //find the user recipe ingredients and send them to the view model


            //find the user recipe directions and send them to the view mode
            _userRecipeData.RecipeIngredients = user.Recipes.ToList();
            //after the user is found get all of their recipes
            foreach (var item in db.Recipes)
            {

                if (userId == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            
                try
                {
                    if(item.UserID == userId)
                    {
                        _userRecipeData.UserRecipes.Add(item);
                    }

                    if(_userRecipeData.UserRecipes.Count() == 0)
                    {
                        _userRecipeData.Message = "No Recipes Exist For This User";
                    }
                }

                catch
                {
                    _userRecipeData.ErrorMessage = "Hmmmm something wwent wrong, couldn't locate that user.";
                    //have the option to reload the page? or redirect back to a different page
                }

            }

            return View(_userRecipeData);

        }

        public ActionResult GetAllRecipeData (Guid userId)
        {
            ICollection<Direction> directions = new List<Direction>();
            ICollection<Ingredient> ingredients = new List<Ingredient>();


            recipes = db.Recipes.Where(r => r.UserID == userId).ToList();
            ingredients = db
            return View()
        }
    }
}
