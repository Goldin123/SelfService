using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelfService.Controllers
{
    //NB!!!!!!!!!
    //PLEASE DO NOT FORGET TO PUBLISH THE SelfServiceSQLDB Project to make use of the application.
    //The SQL server instance to use is '(localdb)\ProjectsV13' and you can use you windows credentials to access Database ''
    public class HomeController : Controller
    {
        private SelfService.Business.Interface.IEmployeeBL _employee = new SelfService.Business.Abstract.EmployeeBL();
        private SelfService.Business.Interface.IDashboardBL _dashboard = new SelfService.Business.Abstract.DashboardBL();
        public ActionResult Index()
        {
            var rst = _dashboard.GetDashboard();
            return View(rst);
        }

        public ActionResult Employees()
        {
            return View();
        }

        public ActionResult EmployeeDetails(string data)
        {
            var rst = new SelfService.Model.ViewEmployee();
            var iEmployeeID = Convert.ToInt32(data);
            if (iEmployeeID > 0)
                rst = _employee.GetEmployeeDetails(iEmployeeID);

            return View(rst);
        }

        [HttpPost]
        public ActionResult AddEditEmployee(SelfService.Model.ViewEmployee viewEmployee)
        {
            if (ModelState.IsValid)
            {
                var rstEmployee = _employee.AddEditEmployee(viewEmployee);
                if (rstEmployee != null)
                    return Json(new { Valid = true, ID = rstEmployee.ID, msg = rstEmployee.Message });
                else
                    return Json(new { Valid = false, ID = 0, msg = "Oops something went wrong" });
            }
            else
                return Json(new { Valid = false, ID = 0, msg = "Oops something went wrong" });
        }

        public ActionResult GetEmployees()
        {
            var data = _employee.GetEmployees();
            return Json(new { data }, JsonRequestBehavior.AllowGet);
        }


    }
}