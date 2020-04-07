using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Moses.Data;
using Moses.Models;

namespace Moses.Controllers
{
    public class PiesController : Controller
    {
        private MosesContext db = new MosesContext();

        // GET: Pies
        public ActionResult Index(string searchString)
        {
            var Pies = from m in db.Pies
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                Pies = Pies.Where(s => s.Name.Contains(searchString));
            }

            return View(Pies);
        }

        // GET: Pies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pie pie = db.Pies.Find(id);
            if (pie == null)
            {
                return HttpNotFound();
            }
            return View(pie);
        }

        // POST: Pies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ImgUrl,Price,ShortDescription,LongDescription,CategotyId")] Pie pie)
        {
            if (ModelState.IsValid)
            {
                db.Pies.Add(pie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pie);
        }

        // GET: Pies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pie pie = db.Pies.Find(id);
            if (pie == null)
            {
                return HttpNotFound();
            }
            return View(pie);
        }

        // POST: Pies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ImgUrl,Price,ShortDescription,LongDescription,CategotyId")] Pie pie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pie);
        }

        // GET: Pies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pie pie = db.Pies.Find(id);
            if (pie == null)
            {
                return HttpNotFound();
            }
            return View(pie);
        }

        // POST: Pies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pie pie = db.Pies.Find(id);
            db.Pies.Remove(pie);
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
