using InsuranceCompanyProject.FollowApi;
using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
namespace InsuranceCompanyProject.Controllers
{
    public class DefaultController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();
        public async Task<ActionResult> Index()
        {
            var linkedInApi = new LinkedInApi();
            int followerCount = await linkedInApi.GetLinkedInProfiles();


            var instagramApiId = new InstagramApi();
            int instagramUserId = await instagramApiId.GetInstagramProfileId("BURAYA_KULLANICI_ADINI_YAZ");

            int followerCountInstagram = await instagramApiId.GetInstagramProfileData(instagramUserId);

            ViewBag.LinkedInFollowerCount = followerCount;
            ViewBag.InstagramFollowerCount = followerCountInstagram;

            return View();
        }

        public PartialViewResult Slider()
        {
            var value = db.TblSlider.ToList();
            return PartialView(value);
        }

        public PartialViewResult About()
        {
            var value = db.TblAbout.ToList();
            return PartialView(value);
        }
        public PartialViewResult Features()
        {
            var value = db.TblFeature.ToList();
            return PartialView(value);
        }
        public PartialViewResult Services()
        {
            var value = db.TblServices.ToList();
            return PartialView(value);
        }
        public PartialViewResult Testimonial()
        {
            var value = db.TblTestimonial.ToList();
            return PartialView(value);
        }
        public PartialViewResult Communication()
        {
            var value = db.TblCommunication.ToList();
            return PartialView(value);
        }
        public PartialViewResult Question()
        {
            var value = db.TblQuestion.ToList();
            return PartialView(value);
        }
        public PartialViewResult Employee()
        {
            var value = db.TblEmployee.ToList();
            return PartialView(value);
        }



    }
}