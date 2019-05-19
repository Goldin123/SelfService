using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfService.Model;

namespace SelfService.Data.Inteface
{
    public interface IEmployeeDB
    {
        Result AddEditEmployee(ViewEmployee employee);
        ViewEmployee GetEmployeeDetails(int employeeID);
        List<ViewEmployee> GetEmployees();
    }
}
