using SelfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.Business.Interface
{
    public interface IEmployeeBL
    {
        Result AddEditEmployee(ViewEmployee employee);
        ViewEmployee GetEmployeeDetails(int employeeID);
        List<ViewEmployee> GetEmployees();
    }
}
