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
    public class UserController : Controller
    {
        private RecipeTrackerContext db = new RecipeTrackerContext();

        // GET: User
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDisplay([Bind(Include="UserId, LastName, FirstName, Email")] User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "The information needs addiitonal correction.";             
            }

            return View(user);
            
        }

        //Get : User/EditDisplay/5
        public ActionResult EditDisplay(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try
            {
                User user = db.Users.Find(id);
                
                if(user == null)
                {
                    return HttpNotFound();
                }
                
                return View(user);

            }
            catch
            {
                ViewBag.ErrorMessage = "We were not able to locate the user, please try again";
            }

            return View(id);
            
        }



        // GET: User/Details/5

            //replace the controller in this view to use EditDisplay Method
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,LastName,FirstName,Email")] User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    user.UserID = Guid.NewGuid().ToString();
                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    ViewBag.ErrorMessage = "We were not able to create a user at this time if this issue continues please contact you administrator";
                }
            }

            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try
            {
                User user = db.Users.Find(id);

                if (user == null)
                {
                    return HttpNotFound();
                }

                return View(user);
            }
            catch
            {
                ViewBag.ErrorMessage = "We are not able to locate the user at this time. Please try again later";
            }

            return View(id);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,LastName,FirstName,Email")] User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "We cannot edit user at this time. Please try again later";
            }
            
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            User user = db.Users.Find(id);
            
            try
            {
                
                if (user == null)
                {
                    return HttpNotFound();
                }

                return View(user);
            }
            catch
            {
                ViewBag.ErrorMessage = "we were not able to delete user at this time. If the problem persists please contact your network administrator";
            }
            
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            User user = db.Users.Find(id);
            
            try
            {    
                db.Users.Remove(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.ErrorMessage = "Not able to delete confirm deletion of user at this time. Please refer to system administrator if problem persists.";
            }

            return View("Delete", id);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
