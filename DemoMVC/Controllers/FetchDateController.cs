using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class FetchDateController : Controller
    {
        // GET: FetchDate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            DateTime Sdate = DateTime.Parse(Request.Form["txtStDate"]);
            DateTime Edate = DateTime.Parse(Request.Form["txtEdDate"]);
            ViewBag.D=DBOperations.GetData(Sdate, Edate);
            return View("Index");
        }
    }
}