using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceCompanyProject.Controllers
{
    public class TestimonialController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();

        public ActionResult TestimonialList()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial testimonial)
        {
            db.TblTestimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial testimonial)
        {
            var value = db.TblTestimonial.Find(testimonial.TestimonialId);

            value.TestimonialName = testimonial.TestimonialName;
            value.TestimonialSurname = testimonial.TestimonialSurname;
            value.TestimonialJob = testimonial.TestimonialJob;
            value.TestimonialPoint = testimonial.TestimonialPoint;
            value.TestimonialComment = testimonial.TestimonialComment;
            value.TestimonialImageUrl = testimonial.TestimonialImageUrl;
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}