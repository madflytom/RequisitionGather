using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InvestigatorReq.Models;

namespace InvestigatorReq.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Requisition()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormSubmission(Object formObjects) {
            return Json(new { data = formObjects });
        }

        public ActionResult GetQuestions(string id)
        {
            Requisition thisBeautifulReq = DAL.BuildFormElements(id);
            
            return View(thisBeautifulReq);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}