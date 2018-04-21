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
    public class ThreeDPrintingProjectsController : Controller
    {
        private MyPortfolioContext db = new MyPortfolioContext();

        // GET: ThreeDPrintingProjects
        public ActionResult Index()
        {
            return View(db.ThreeDPrintingProjects.ToList());
        }

        // GET: ThreeDPrintingProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThreeDPrintingProject threeDPrintingProject = db.ThreeDPrintingProjects.Find(id);
            if (threeDPrintingProject == null)
            {
                return HttpNotFound();
            }
            return View(threeDPrintingProject);
        }

        // GET: ThreeDPrintingProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThreeDPrintingProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProjectTitle,UploadDate")] ThreeDPrintingProject threeDPrintingProject)
        {
            if (ModelState.IsValid)
            {
                db.ThreeDPrintingProjects.Add(threeDPrintingProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(threeDPrintingProject);
        }

        // GET: ThreeDPrintingProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThreeDPrintingProject threeDPrintingProject = db.ThreeDPrintingProjects.Find(id);
            if (threeDPrintingProject == null)
            {
                return HttpNotFound();
            }
            return View(threeDPrintingProject);
        }

        // POST: ThreeDPrintingProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProjectTitle,UploadDate")] ThreeDPrintingProject threeDPrintingProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(threeDPrintingProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(threeDPrintingProject);
        }

        // GET: ThreeDPrintingProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThreeDPrintingProject threeDPrintingProject = db.ThreeDPrintingProjects.Find(id);
            if (threeDPrintingProject == null)
            {
                return HttpNotFound();
            }
            return View(threeDPrintingProject);
        }

        // POST: ThreeDPrintingProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThreeDPrintingProject threeDPrintingProject = db.ThreeDPrintingProjects.Find(id);
            db.ThreeDPrintingProjects.Remove(threeDPrintingProject);
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
