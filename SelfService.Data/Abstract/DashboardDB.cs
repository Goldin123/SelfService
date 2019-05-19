using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfService.Data.Inteface;
using SelfService.Model;

namespace SelfService.Data.Abstract
{
    public sealed class DashboardDB : Inteface.IDashboardDB
    {
        Dashboard IDashboardDB.GetDashboard()
        {
            try
            {
                using (var db = new DB.SelfServiceSQLDBEntities1())
                {
                    var _employees = (from a in db.Employees select a);
                    if (_employees != null)
                    {

                        var iTotalEmployees = _employees.Count();
                        var iTotalEmployeesAddedToday = _employees.Where(a => EntityFunctions.TruncateTime(a.DateCreated) == DateTime.Today).Count();
                        var iTotalMaleEmployees = _employees.Where(a => a.Gender == "Male").Count();
                        var iTotalFemaleEmployees = _employees.Where(a => a.Gender == "Female").Count();

                        return new Dashboard {
                            TotalEmployeesAddedToday = iTotalEmployeesAddedToday,
                            TotalEmplyees  = iTotalEmployees,
                            TotalFemale  = iTotalFemaleEmployees,
                            TotalMale = iTotalMaleEmployees
                        };

                    }
                    else
                    {
                        return new Dashboard();
                    }
                }
            }
            catch
            {
                return new Dashboard();
            }
        }
    }
}
