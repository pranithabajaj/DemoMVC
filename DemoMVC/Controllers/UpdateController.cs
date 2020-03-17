using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class UpdateController : Controller
    {
        // GET: Update
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetDetails()
        {
            //if empno is coming through address we shld use querystring
            int empno = int.Parse(Request.QueryString["empno"]);
            //ViewBag.S = empno;
            EMPDATA E = DBOperations.GetDetails(empno);
            return View("Index", E);
        }
        public ActionResult Update(EMPDATA Emp)
        {
            int empno = int.Parse(Request.Form["empno"]);
             string s= DBOperations.GetEmpData(Emp);
            ViewBag.msg = s;
            return View("Index");
        }
        
    }
}