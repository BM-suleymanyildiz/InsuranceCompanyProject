using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceCompanyProject.Controllers
{
    public class AboutController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();

        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();

            if (!values.Any())
            {
                ViewBag.Test = "VERİ YOK";
            }
            else
            {
                ViewBag.Test = "VERİ VAR";
            }

            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(TblAbout about)
        {
            db.TblAbout.Add(about);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(TblAbout about)
        {
            var value = db.TblAbout.Find(about.AboutId);
            value.AboutTitle = about.AboutTitle;
            value.AboutSubtitle = about.AboutSubtitle;
            value.AboutDescription1 = about.AboutDescription1;
            value.AboutDescription2 = about.AboutDescription2;
            value.AboutSlogan1 = about.AboutSlogan1;
            value.AboutSlogan2 = about.AboutSlogan2;
            value.AboutSlogan3 = about.AboutSlogan3;
            value.InsurancePoliciesCount = about.InsurancePoliciesCount;
            value.AwardsCount = about.AwardsCount;
            value.SkilledAgentsCount = about.SkilledAgentsCount;
            value.TeamMembersCount = about.TeamMembersCount;
            value.ImageUrl = about.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}