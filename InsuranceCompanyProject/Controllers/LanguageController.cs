using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceCompanyProject.Controllers
{
    public class LanguageController : Controller
    {

        public ActionResult Change(string lang, string returnUrl)
        {
            
            HttpCookie langCookie = new HttpCookie("lang", lang)
            {
                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Add(langCookie);

            return Redirect(returnUrl ?? "/");
        }
    }
}