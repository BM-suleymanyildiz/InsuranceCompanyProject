using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using InsuranceCompanyProject.ViewModels;
using System.IO;

namespace InsuranceCompanyProject.Controllers
{
    public class ServicesController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();


        public ActionResult ServiesList()
        {
            var values = db.TblServices.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<JsonResult> GenerateAIImage(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                return Json(new { error = "Prompt boş! Frontend'den gelen prompt: " + (prompt ?? "null") }, JsonRequestBehavior.AllowGet);

            // !!! DİKKAT: Gerçek API anahtarınızı ve model URL'nizi burada paylaşmayın. Aşağıdaki değerleri kendi ortamınızda gizli tutun.
            var apiKey = "YOUR_HUGGINGFACE_API_KEY";
            var apiUrl = "https://api-inference.huggingface.co/models/YOUR_MODEL_PATH";

            var contentString = $"{{\"inputs\": \"{prompt}\"}}";
            var content = new StringContent(contentString, Encoding.UTF8, "application/json");

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    var response = await client.PostAsync(apiUrl, content);
                    var body = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var bytes = await response.Content.ReadAsByteArrayAsync();
                        var fileName = $"{Guid.NewGuid()}.png";
                        var relativePath = $"/Content/AiImages/{fileName}";
                        var serverPath = System.Web.HttpContext.Current.Server.MapPath(relativePath);
                        Directory.CreateDirectory(Path.GetDirectoryName(serverPath));
                        System.IO.File.WriteAllBytes(serverPath, bytes);
                        return Json(new { imageUrl = relativePath }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { error = $"API Hatası: {response.StatusCode}", prompt, contentString, body }, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { error = $"Hata: {ex.Message}", prompt, contentString }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult CreateServices()
        {
            var model = new TblServices();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateServices(TblServices service)
        {
            db.TblServices.Add(service);
            db.SaveChanges();
            return RedirectToAction("ServiesList");
        }

        public ActionResult DeleteServices(int id)
        {
            var value = db.TblServices.Find(id);
            db.TblServices.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ServiesList");
        }

        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var value = db.TblServices.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateServices(TblServices service)
        {
            var value = db.TblServices.Find(service.ServicesId);
            value.ServicesCardIcon = service.ServicesCardIcon;
            value.ServicesCardImageUrl = service.ServicesCardImageUrl;
            value.ServicesCardTitle = service.ServicesCardTitle;
            value.ServicesCardDescription = service.ServicesCardDescription;
            db.SaveChanges();
            return RedirectToAction("ServiesList");
        }

    }
}



