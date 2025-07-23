using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceCompanyProject.Controllers
{
    public class FeatureController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();

        public ActionResult FeatureList()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(TblFeature feature)
        {
            db.TblFeature.Add(feature);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        public ActionResult DeleteFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            db.TblFeature.Remove(value);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(TblFeature feature)
        {
            var value = db.TblFeature.Find(feature.FeatureId);

            value.FeatureCardIcon = feature.FeatureCardIcon;
            value.FeatureCardTitle = feature.FeatureCardTitle;
            value.FeatureCardDescription = feature.FeatureCardDescription;

            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}