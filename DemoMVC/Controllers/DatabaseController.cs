using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DatabaseController : Controller
    {
        static List<DEPTDATA> List = null;
        static List<EMPDATA> List1 = null;
        // GET: Database
        public ActionResult Index()
        {
            EMPDATA E = new EMPDATA();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index(EMPDATA E)
        {
            ViewBag.msg=DBOperations.InsertEmp(E);
            return View();
        }
        public ActionResult getDeptData()
        {
            return View();
        }
        public ActionResult getDept()
        {
           
            int deptno = int.Parse(Request.Form["txtDeptno"]);
            //List<EMPDATA> L=DBOperations.getDept(deptno);
            ViewBag.L= DBOperations.getDept(deptno);
            //return View("getDeptData",L);
            return View("getDeptData");
        }
       public ActionResult getDepts()
        {
            List = DBOperations.getDepts();
            ViewBag.DL = List;
            return View();
        }
       public ActionResult SendDept()
        {
           int deptno = int.Parse(Request.QueryString["d"]);
            ViewBag.DL = List;
            ViewBag.S = deptno;
            List<EMPDATA> EL=DBOperations.getDept(deptno);
            return View("getDepts",EL);
        }
        public ActionResult delDept()
        {
            List1 = DBOperations.delDept();
            ViewBag.EL = List1;
            return View();
        }
        public ActionResult Send()
        {
            
            ViewBag.EL = List1;
            
            List<EMPDATA> EL = DBOperations.delDept();
            return View("getDepts", EL);

        }
}
}