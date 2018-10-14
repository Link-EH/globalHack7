using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class ResumeSkillController : Controller
    {
        public EmploymentDatabase db = new EmploymentDatabase();

        public ActionResult Edit(Guid? id)
        {


            return View(db.SkillCategory.ToList());
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