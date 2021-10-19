using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAdvertiseApplication.Models;

namespace WebAdvertiseApplication.Controllers
{
    public class ConsultantsController : Controller
    {
        private Consultants db = new Consultants();

        // GET: Consultants
        public ActionResult Index()
        {
            return View(db.Consultant.ToList());
        }

        // GET: Consultants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultant consultant = db.Consultant.Find(id);
            if (consultant == null)
            {
                return HttpNotFound();
            }
            return View(consultant);
        }

        // GET: Consultants/Create
        [Authorize(Roles = "Consultant")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Consultant")]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,email,gender,Available_time,Rating,UserId")] Consultant consultant)
        {
            if (ModelState.IsValid)
            {
                db.Consultant.Add(consultant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consultant);
        }

        // GET: Consultants/Edit/5
        [Authorize(Roles = "Consultant")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultant consultant = db.Consultant.Find(id);
            if (consultant == null)
            {
                return HttpNotFound();
            }
            return View(consultant);
        }

        // POST: Consultants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Consultant")]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,email,gender,Available_time,Rating,UserId")] Consultant consultant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consultant);
        }

        // GET: Consultants/Delete/5
        [Authorize(Roles = "Consultant")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consultant consultant = db.Consultant.Find(id);
            if (consultant == null)
            {
                return HttpNotFound();
            }
            return View(consultant);
        }

        // POST: Consultants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Consultant")]
        public ActionResult DeleteConfirmed(int id)
        {
            Consultant consultant = db.Consultant.Find(id);
            db.Consultant.Remove(consultant);
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
