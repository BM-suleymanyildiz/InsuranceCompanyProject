using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceCompanyProject.Controllers
{
    public class CommunicationController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();
        public ActionResult CommunicationList()
        {
            var values = db.TblCommunication.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateCommunication()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCommunication(TblCommunication communication)
        {
            db.TblCommunication.Add(communication);
            db.SaveChanges();
            return RedirectToAction("CommunicationList");
        }

        public ActionResult DeleteCommunication(int id)
        {
            var value = db.TblCommunication.Find(id);
            db.TblCommunication.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CommunicationList");
        }
        [HttpGet]
        public ActionResult UpdateCommunication(int id)
        {
            var value = db.TblCommunication.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCommunication(TblCommunication communication)
        {
            var value = db.TblCommunication.Find(communication.CommunicationId);
            value.Adress = communication.Adress;
            value.Mail = communication.Mail;
            value.Telephone = communication.Telephone;
            db.SaveChanges();
            return RedirectToAction("CommunicationList");
        }
    }
}