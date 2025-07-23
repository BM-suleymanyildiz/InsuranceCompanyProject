using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceCompanyProject.Controllers
{
    public class EmployeeController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();

        public ActionResult EmployeeList()
        {
            var values = db.TblEmployee.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(TblEmployee employee)
        {
            db.TblEmployee.Add(employee);
            db.SaveChanges();
            return RedirectToAction("EmployeeList");
        }

        public ActionResult DeleteEmployee(int id)
        {
            var value = db.TblEmployee.Find(id);
            db.TblEmployee.Remove(value);
            db.SaveChanges();
            return RedirectToAction("EmployeeList");
        }
        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            var value = db.TblEmployee.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(TblEmployee employee)
        {
            var value = db.TblEmployee.Find(employee.EmloyeeId);

            value.EmployeImageUrl = employee.EmployeImageUrl;
            value.EmployeeName = employee.EmployeeName;
            value.EmpolyeeSurname = employee.EmpolyeeSurname;
            value.EmployeeJob = employee.EmployeeJob;
            value.EmployeeSocialMedia1 = employee.EmployeeSocialMedia1;
            value.EmployeeSocialMedia2 = employee.EmployeeSocialMedia2;
            value.EmployeeSocialMedia3 = employee.EmployeeSocialMedia3;
            value.EmployeeSocialMedia4 = employee.EmployeeSocialMedia4;
            db.SaveChanges();
            return RedirectToAction("EmployeeList");
        }
    }
}