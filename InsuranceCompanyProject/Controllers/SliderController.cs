using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceCompanyProject.Controllers
{
    public class SliderController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();

        public ActionResult SliderList()
        {
            var values = db.TblSlider.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSlider(TblSlider slider)
        {
            db.TblSlider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("SliderList");
        }

        public ActionResult DeleteSlider(int id)
        {
            var value = db.TblSlider.Find(id);
            db.TblSlider.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var value = db.TblSlider.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSlider(TblSlider slider)
        {
            var value = db.TblSlider.Find(slider.SliderId);
            value.SliderTitle = slider.SliderTitle;
            value.SliderSubtitle = slider.SliderSubtitle;
            value.SliderDescription = slider.SliderDescription;
            value.SliderImageUrl = slider.SliderImageUrl;
            db.SaveChanges();
            return RedirectToAction("SliderList");

        }
    }
}