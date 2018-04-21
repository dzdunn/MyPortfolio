using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.DAL;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class DroneProjectsController : Controller
    {
        private MyPortfolioContext db = new MyPortfolioContext();

        // GET: DroneProjects
        public ActionResult Index()
        {
            return View(db.DroneProjects.ToList());
        }

        // GET: DroneProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DroneProject droneProject = db.DroneProjects.Find(id);
            if (droneProject == null)
            {
                return HttpNotFound();
            }
            return View(droneProject);
        }

        // GET: DroneProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DroneProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProjectTitle,UploadDate")] DroneProject droneProject)
        {
            if (ModelState.IsValid)
            {
                db.DroneProjects.Add(droneProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(droneProject);
        }

        // GET: DroneProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DroneProject droneProject = db.DroneProjects.Find(id);
            if (droneProject == null)
            {
                return HttpNotFound();
            }
            return View(droneProject);
        }

        // POST: DroneProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProjectTitle,UploadDate")] DroneProject droneProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(droneProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(droneProject);
        }

        // GET: DroneProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DroneProject droneProject = db.DroneProjects.Find(id);
            if (droneProject == null)
            {
                return HttpNotFound();
            }
            return View(droneProject);
        }

        // POST: DroneProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DroneProject droneProject = db.DroneProjects.Find(id);
            db.DroneProjects.Remove(droneProject);
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
