using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using RecipeTracker.DAL;
using RecipeTracker.Models;

namespace RecipeTracker.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private RecipeTrackerContext db = new RecipeTrackerContext();

        // GET: User
        [AllowAnonymous]
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.LastNameSortParams = String.IsNullOrEmpty(sortOrder) ? "last_name_desc" : "";
            
            if(searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            try
            {

                var users = from u in db.Users
                            select u;

                if (!String.IsNullOrEmpty(searchString))
                {
                    users = users.Where(u => u.LastName.Contains(searchString)
                        || u.FirstName.Contains(searchString));
                }

                switch (sortOrder)
                {
                    case "last_name_desc":
                        users = users.OrderByDescending(u => u.LastName);
                        break;

                    default:
                        users = users.OrderBy(u => u.LastName);
                        break;
                }

                int pageSize = 3;
                int pageNumber = (page ?? 1);// the ?? means if the value is present then use the current value, if page has no value assign 1 as its value)

                return View(users.ToPagedList(pageNumber, pageSize));

            }
            catch
            {

                ViewBag.ErrorMessage = "We cannot locate the users at this time. please try again later. If problem persist please contact your Network Administrator";
                return View("~Controllers/Home");
                                       
            }
            

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
            var id1 = id.ToString();
            User user = db.Users.Find(id1);
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
                var id1 = id.ToString();
                User user = db.Users.Find(id1);

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
