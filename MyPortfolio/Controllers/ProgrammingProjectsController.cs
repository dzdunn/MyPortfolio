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
    public class ProgrammingProjectsController : Controller
    {
        private MyPortfolioContext db = new MyPortfolioContext();

        // GET: ProgrammingProjects
        public ActionResult Index()
        {
            return View(db.ProgrammingProjects.ToList());
        }

        // GET: ProgrammingProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgrammingProject programmingProject = db.ProgrammingProjects.Find(id);
            if (programmingProject == null)
            {
                return HttpNotFound();
            }
            return View(programmingProject);
        }

        // GET: ProgrammingProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProgrammingProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProjectTitle,UploadDate")] ProgrammingProject programmingProject)
        {
            if (ModelState.IsValid)
            {
                db.ProgrammingProjects.Add(programmingProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(programmingProject);
        }

        // GET: ProgrammingProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgrammingProject programmingProject = db.ProgrammingProjects.Find(id);
            if (programmingProject == null)
            {
                return HttpNotFound();
            }
            return View(programmingProject);
        }

        // POST: ProgrammingProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProjectTitle,UploadDate")] ProgrammingProject programmingProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programmingProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(programmingProject);
        }

        // GET: ProgrammingProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgrammingProject programmingProject = db.ProgrammingProjects.Find(id);
            if (programmingProject == null)
            {
                return HttpNotFound();
            }
            return View(programmingProject);
        }

        // POST: ProgrammingProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProgrammingProject programmingProject = db.ProgrammingProjects.Find(id);
            db.ProgrammingProjects.Remove(programmingProject);
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
