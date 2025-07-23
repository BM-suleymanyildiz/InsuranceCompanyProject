using InsuranceCompanyProject.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace InsuranceCompanyProject.Controllers
{
    public class QuestionController : Controller
    {
        InsuranceCompanyDbEntities db = new InsuranceCompanyDbEntities();

        public ActionResult QuestionList()
        {
            var values = db.TblQuestion.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateQuestion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateQuestion(TblQuestion question)
        {
            db.TblQuestion.Add(question);
            db.SaveChanges();
            return RedirectToAction("QuestionList");
        }

        public ActionResult DeleteQuestion(int id)
        {
            var value = db.TblQuestion.Find(id);
            db.TblQuestion.Remove(value);
            db.SaveChanges();
            return RedirectToAction("QuestionList");
        }
        [HttpGet]
        public ActionResult UpdateQuestion(int id)
        {
            var value = db.TblQuestion.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateQuestion(TblQuestion question)
        {
            var value = db.TblQuestion.Find(question.QuestionId);
            value.Questioon = question.Questioon;
            value.Answer = question.Answer;
            db.SaveChanges();
            return RedirectToAction("QuestionList");
        }

        [HttpPost]
        public async Task<JsonResult> GenerateAIQuestion(string topic)
        {
            try
            {
                string prompt = string.IsNullOrWhiteSpace(topic)
                    ? "Sigortacılıkla ilgili bir soru ve cevabı üret. Sadece soru ve cevap üret, başka bir şey yazma."
                    : $"{topic} ile ilgili bir sigortacılık sorusu ve cevabı üret. Sadece soru ve cevap üret, başka bir şey yazma.";
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://chatgpt-42.p.rapidapi.com/conversationgpt4"),
                    Headers =
                    {
                        { "x-rapidapi-key", "YOUR_RAPIDAPI_KEY" },
                        { "x-rapidapi-host", "YOUR_RAPIDAPI_HOST" },
                    },
                    Content = new StringContent($"{{\"messages\":[{{\"role\":\"user\",\"content\":\"{prompt}\"}}],\"system_prompt\":\"\",\"temperature\":0.9,\"top_k\":5,\"top_p\":0.9,\"max_tokens\":256,\"web_access\":false}}")
                    {
                        Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                    }
                };
                using (var response = await client.SendAsync(request))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    // Cevabı debug için direkt dön
                    string question = "", answer = "";
                    string aiContent = "";
                    try
                    {
                        var json = JObject.Parse(body);
                        // API dökümantasyonuna göre cevap burada olabilir:
                        aiContent = json["result"]?.ToString();
                        if (string.IsNullOrEmpty(aiContent) && json["choices"] != null)
                        {
                            aiContent = json["choices"][0]["message"]["content"]?.ToString();
                        }
                        if (!string.IsNullOrEmpty(aiContent))
                        {
                            var parts = aiContent.Split(new[] { "Soru:", "Cevap:" }, StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 2)
                            {
                                question = parts[0].Trim();
                                answer = parts[1].Trim();
                            }
                        }
                    }
                    catch { }
                    return Json(new { question, answer, aiContent, raw = body }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}