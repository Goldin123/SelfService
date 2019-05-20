using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelfService;
using SelfService.Controllers;

namespace SelfService.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void EmployeesTest()
        {
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Employees() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void GetEmployeesTest()
        {
            HomeController controller = new HomeController();

            // Act
            var result = controller.GetEmployees();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void AddEditEmployeeTest()
        {
            HomeController controller = new HomeController();
            var param = new SelfService.Model.ViewEmployee
            {
                Cell = "0790002406",
                DepartmentID = 1,
                Email = "test@gmail.com",
                FirstName = "Goldin",
                Gender = "Male",
                LastName = "Baloyi",
                PhysicalCode = "2091",
                PhysicalLine1 = "ph1",
                Title = "Mr",
                Telephone = "0790002406",
                PhysicalLine2 = "ph2",
            };
            // Act
            var result = controller.AddEditEmployee(param);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void EmployeeDetailsTest()
        {

            HomeController controller = new HomeController();
            var parm = "";
            // Act
            ViewResult result = controller.EmployeeDetails(parm) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
