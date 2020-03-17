using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class ChechBox
    {

        static TestEntities T = new TestEntities();
        public static List<EMPDATA> GetEmp()
        {
        var Emp = from E in T.EMPDATAs
                  select E;
        return Emp.ToList();
        }
        public static List<EMPDATA> GetEmpData(int[] id)
        {
            var E = from E1 in T.EMPDATAs
                where id.Contains(E1.EMPNO) == true
                select E1;

            return E.ToList();
         }
    }
}
