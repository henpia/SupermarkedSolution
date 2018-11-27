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
    public class VareController : Controller
    {
        private SupermarkedDB db = new SupermarkedDB();

        // GET: Vare
        public ActionResult Index()
        {
            var varer = db.Varer.Include(v => v.Varegruppe);
            return View(varer.ToList());
        }

        // GET: Vare/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vare vare = db.Varer.Find(id);
            if (vare == null)
            {
                return HttpNotFound();
            }
            return View(vare);
        }

        // GET: Vare/Create
        public ActionResult Create()
        {
            ViewBag.VaregruppeId = new SelectList(db.Varegrupper, "VaregruppeId", "Betegnelse");
            return View();
        }

        // POST: Vare/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VareId,Betegnelse,Beskrivelse,Pris,AntalPaaLager,VaregruppeId")] Vare vare)
        {
            if (ModelState.IsValid)
            {
                db.Varer.Add(vare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VaregruppeId = new SelectList(db.Varegrupper, "VaregruppeId", "Betegnelse", vare.VaregruppeId);
            return View(vare);
        }

        // GET: Vare/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vare vare = db.Varer.Find(id);
            if (vare == null)
            {
                return HttpNotFound();
            }
            ViewBag.VaregruppeId = new SelectList(db.Varegrupper, "VaregruppeId", "Betegnelse", vare.VaregruppeId);
            return View(vare);
        }

        // POST: Vare/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VareId,Betegnelse,Beskrivelse,Pris,AntalPaaLager,VaregruppeId")] Vare vare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VaregruppeId = new SelectList(db.Varegrupper, "VaregruppeId", "Betegnelse", vare.VaregruppeId);
            return View(vare);
        }

        // GET: Vare/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vare vare = db.Varer.Find(id);
            if (vare == null)
            {
                return HttpNotFound();
            }
            return View(vare);
        }

        // POST: Vare/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vare vare = db.Varer.Find(id);
            db.Varer.Remove(vare);
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
