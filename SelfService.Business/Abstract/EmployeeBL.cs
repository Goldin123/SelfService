using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfService.Business.Interface;
using SelfService.Model;

namespace SelfService.Business.Abstract
{
    public sealed class EmployeeBL : Interface.IEmployeeBL
    {
        private SelfService.Data.Inteface.IEmployeeDB _employeeDB = new SelfService.Data.Abstract.EmployeeDB();
        Result IEmployeeBL.AddEditEmployee(ViewEmployee employee) => _employeeDB.AddEditEmployee(employee);
        ViewEmployee IEmployeeBL.GetEmployeeDetails(int employeeID) => _employeeDB.GetEmployeeDetails(employeeID);
        List<ViewEmployee> IEmployeeBL.GetEmployees() => _employeeDB.GetEmployees();
        
    }
}
