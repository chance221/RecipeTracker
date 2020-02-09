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
    public class DirectionController : Controller
    {
        private RecipeTrackerContext db = new RecipeTrackerContext();

        // GET: Direction
        public ActionResult Index()
        {
            return View(db.Directions.ToList());
        }

        // GET: Direction/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direction direction = db.Directions.Find(id);
            if (direction == null)
            {
                return HttpNotFound();
            }
            return View(direction);
        }

        // GET: Direction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Direction/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DirectionID,StepNum,Instruction,RecipeID")] Direction direction)
        {
            if (ModelState.IsValid)
            {
                direction.DirectionID = Guid.NewGuid();
                db.Directions.Add(direction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(direction);
        }

        // GET: Direction/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direction direction = db.Directions.Find(id);
            if (direction == null)
            {
                return HttpNotFound();
            }
            return View(direction);
        }

        // POST: Direction/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DirectionID,StepNum,Instruction,RecipeID")] Direction direction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(direction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(direction);
        }

        // GET: Direction/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direction direction = db.Directions.Find(id);
            if (direction == null)
            {
                return HttpNotFound();
            }
            return View(direction);
        }

        // POST: Direction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Direction direction = db.Directions.Find(id);
            db.Directions.Remove(direction);
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
    }
}
