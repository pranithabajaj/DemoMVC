using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class RadioController : Controller
    {
        // GET: Radio
        List<DEPTDATA> List = null;
        List<EMPDATA> list1 = null;
        public ActionResult Index()
        {
            List = DBOperations.getDepts();
            ViewBag.DL = List;
            return View();
        }
        public ActionResult GetData()
        {
            List = DBOperations.getDepts();
            ViewBag.DL = List;
            if (Request.Form["txtStDate"] != null && Request.Form["txtEdDate"] != null)
            {
                DateTime Sdate = DateTime.Parse(Request.Form["txtStDate"]);
                DateTime Edate = DateTime.Parse(Request.Form["txtEdDate"]);
                list1 = DBOperations.GetData(Sdate, Edate);
                ViewBag.l = list1;
            }
            if (Request.Form["ddlDeptno"] != null)
            {
                int deptno = int.Parse(Request.Form["ddlDeptno"]);
                list1 = DBOperations.getDept(deptno);
                ViewBag.l = list1;

            }
            return View("Index");
        }
    }
}