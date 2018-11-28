using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Supermarked.Models;

namespace Supermarked.Controllers
{
    public class VaregruppeController : Controller
    {
        private SupermarkedDB db = new SupermarkedDB();

        // GET: Varegruppe
        public ActionResult Index()
        {
            return View(db.Varegrupper.ToList());
        }

        // GET: Varegruppe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varegruppe varegruppe = db.Varegrupper.Find(id);
            if (varegruppe == null)
            {
                return HttpNotFound();
            }
            return View(varegruppe);
        }

        // GET: Varegruppe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Varegruppe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VaregruppeId,Betegnelse")] Varegruppe varegruppe)
        {
            if (ModelState.IsValid)
            {
                db.Varegrupper.Add(varegruppe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(varegruppe);
        }

        // GET: Varegruppe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varegruppe varegruppe = db.Varegrupper.Find(id);
            if (varegruppe == null)
            {
                return HttpNotFound();
            }
            return View(varegruppe);
        }

        // POST: Varegruppe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VaregruppeId,Betegnelse")] Varegruppe varegruppe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(varegruppe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(varegruppe);
        }

        // GET: Varegruppe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varegruppe varegruppe = db.Varegrupper.Find(id);
            if (varegruppe == null)
            {
                return HttpNotFound();
            }
            return View(varegruppe);
        }

        // POST: Varegruppe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Varegruppe varegruppe = db.Varegrupper.Find(id);
            db.Varegrupper.Remove(varegruppe);
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
