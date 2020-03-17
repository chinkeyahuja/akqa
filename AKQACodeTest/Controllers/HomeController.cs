using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AKQACodeTest.Controllers
{
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public ActionResult UserEntry()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult UserEntry(FormCollection formCollection, string command)
        {
            ValuesController obj = new ValuesController();

            ViewBag.Title = formCollection["txtUserName"].ToUpper();
            ViewBag.Message = obj.Get(formCollection["txtNumber"]).ToUpper();
            return View();
        }
    }
}
