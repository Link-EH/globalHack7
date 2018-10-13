using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class BusinessProfileController : Controller
    {
        private EmploymentDatabase db = new EmploymentDatabase();

        // GET: BusinessProfile
        public ActionResult Index()
        {
            return View(db.BusinessProfiles.ToList());
        }

        // GET: BusinessProfile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            if (businessProfile == null)
            {
                return HttpNotFound();
            }
            return View(businessProfile);
        }

        // GET: BusinessProfile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessProfile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BusinessId,BusinessName,BusinessIndustry,ShortBusinessDescription,LongBusinessDescription,State,City,StreetAddress,EmailAddress,PhoneNumber,Image")] BusinessProfile businessProfile)
        {
            if (ModelState.IsValid)
            {
                db.BusinessProfiles.Add(businessProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(businessProfile);
        }

        // GET: BusinessProfile/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            if (businessProfile == null)
            {
                return HttpNotFound();
            }
            return View(businessProfile);
        }

        // POST: BusinessProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusinessId,BusinessName,BusinessIndustry,ShortBusinessDescription,LongBusinessDescription,State,City,StreetAddress,EmailAddress,PhoneNumber,Image")] BusinessProfile businessProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(businessProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(businessProfile);
        }

        // GET: BusinessProfile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            if (businessProfile == null)
            {
                return HttpNotFound();
            }
            return View(businessProfile);
        }

        // POST: BusinessProfile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusinessProfile businessProfile = db.BusinessProfiles.Find(id);
            db.BusinessProfiles.Remove(businessProfile);
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
