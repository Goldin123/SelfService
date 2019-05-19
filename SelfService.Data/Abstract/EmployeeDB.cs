using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfService.Data.Inteface;
using SelfService.Model;

namespace SelfService.Data.Abstract
{
    public sealed class EmployeeDB : Inteface.IEmployeeDB
    {
        Result IEmployeeDB.AddEditEmployee(ViewEmployee employee)
        {
            try
            {
                using (var db = new DB.SelfServiceSQLDBEntities1())
                {
                    var iEmployeeID = Convert.ToInt32(employee.EmpoloyeeID);
                    if (iEmployeeID == 0)
                    {
                        var _employee = new DB.Employee
                        {
                            Active = true,
                            Cell = employee.Cell,
                            DateCreated = DateTime.Now,
                            DepartmentID = employee.DepartmentID,
                            Email = employee.Email,
                            FirstName = employee.FirstName,
                            Gender = employee.Gender,
                            LastName = employee.LastName,
                            Telephone = employee.Telephone,
                            Title = employee.Title,
                        };
                        db.Employees.Add(_employee);
                        try
                        {
                            db.SaveChanges();
                            employee.EmpoloyeeID = _employee.Id;
                        }
                        catch
                        {
                            employee.EmpoloyeeID = 0;
                        }

                        if (employee.EmpoloyeeID > 0)
                            AddEditEmployeeAdress(employee);

                        return new Result
                        {
                            Valid = true,
                            Message = string.Format("{0} successfully added to the employee list.",_employee.FirstName),
                            ID = _employee.Id
                        };
                    }
                    else
                    {
                        var _employee = (from a in db.Employees.Where(a => a.Id == iEmployeeID) select a).SingleOrDefault();

                        if(_employee != null)
                        {
                            _employee.DateUpdated = DateTime.Now;
                            _employee.DepartmentID = employee.DepartmentID;
                            _employee.Email = employee.Email;
                            _employee.Title = employee.Title;
                            _employee.FirstName = employee.FirstName;
                            _employee.LastName = employee.LastName;
                            _employee.Cell = employee.Cell;
                            _employee.Telephone = employee.Telephone;
                            _employee.Gender = employee.Gender;

                            db.SaveChanges();
                            AddEditEmployeeAdress(employee);
                            return new Result
                            {
                                Valid = true,
                                Message = "Employee successfully updated.",
                                ID = iEmployeeID
                            };
                        }
                        else
                        {
                            return new Result
                            {
                                Valid = false,
                                Message = "Employee details not found, please try again."
                            };
                        }                        
                    }
                }
            }
            catch
            {
                return new Result
                {
                    ID = 0,
                    Message = "Error occurred while trying to save employee details."
                };
            }
        }

        Result AddEditEmployeeAdress(ViewEmployee employee)
        {
            try
            {
                using (var db = new DB.SelfServiceSQLDBEntities1())
                {
                    var _employeeAddress = (from a in db.Addresses.Where(a => a.EmployeeID == employee.EmpoloyeeID)select a).SingleOrDefault();

                    if (_employeeAddress != null) //edit employee address
                    {
                        _employeeAddress.DateUpdated = DateTime.Now;
                        _employeeAddress.PhysicalAddressLine1 = employee.PhysicalLine1;
                        _employeeAddress.PhysicalAddressLine2 = employee.PhysicalLine2;
                        _employeeAddress.PhysicalAddressLine3 = employee.PhysicalLine3;
                        _employeeAddress.PhysicalCode = employee.PhysicalCode;
                        _employeeAddress.PostalAddressLine1 = employee.PostLine1;
                        _employeeAddress.PostalAddressLine2 = employee.PostLine2;
                        _employeeAddress.PostalAddressLine3 = employee.PostLine3;
                        _employeeAddress.PostalCode = employee.PostCode;
                        try { 
                        db.SaveChanges();
                            return new Result
                            {
                                Valid = true,
                                Message ="Successfully updated employee address.",
                                ID = _employeeAddress.Id
                            };
                        }
                        catch
                        {
                            return new Result { Valid = false, Message ="Error occurred trying to update employee address."};
                        }
                        
                    }
                    else //add new employee address
                    {
                        var _address = new DB.Address
                        {
                            Active = true,
                            DateAdded = DateTime.Now,
                            EmployeeID = employee.EmpoloyeeID,
                            PhysicalAddressLine1 = employee.PhysicalLine1,
                            PhysicalAddressLine2 = employee.PhysicalLine2,
                            PhysicalAddressLine3 = employee.PhysicalLine3,
                            PhysicalCode = employee.PhysicalCode,
                            PostalAddressLine1 = employee.PostLine1,
                            PostalAddressLine2 = employee.PostLine2,
                            PostalAddressLine3 = employee.PostLine3,
                            PostalCode = employee.PostCode
                        };

                        db.Addresses.Add(_address);
                        try
                        {
                            db.SaveChanges();
                            return new Result { Valid = true,ID = _address.Id, Message = "Successfully added new employee address." };
                        }
                        catch
                        {
                            return new Result { Valid = false,
                             Message ="Error occurred while trying to add new employee address."};
                        }                        
                    }                    
                }
            }
            catch
            {
                return new Result
                {
                    Valid = false,
                    Message = "Error occurred while trying to save employee address."
                };
            }
        }

        ViewEmployee IEmployeeDB.GetEmployeeDetails(int employeeID)
        {
            try
            {
                using (var db = new DB.SelfServiceSQLDBEntities1())
                {
                    var _employee = (from a in db.Employees.Where(a => a.Id == employeeID) select a).SingleOrDefault();
                    if (_employee != null)
                    {
                        var rst = new ViewEmployee
                        {
                            Cell = _employee.Cell,
                            DepartmentID = _employee.DepartmentID,
                            Email = _employee.Email,
                            EmpoloyeeID = _employee.Id,
                            FirstName = _employee.FirstName,
                            Gender = _employee.Gender,
                            LastName = _employee.LastName,
                            Telephone = _employee.Telephone,
                            Title = _employee.Title,
                            PhysicalLine1 = (from a in _employee.Addresses select a.PhysicalAddressLine1).SingleOrDefault(),
                            PhysicalLine2 = (from a in _employee.Addresses select a.PhysicalAddressLine2).SingleOrDefault(),
                            PhysicalLine3 = (from a in _employee.Addresses select a.PhysicalAddressLine3).SingleOrDefault(),
                            PhysicalCode = (from a in _employee.Addresses select a.PhysicalCode).SingleOrDefault(),
                            PostLine1 = (from a in _employee.Addresses select a.PostalAddressLine1).SingleOrDefault(),
                            PostLine2 = (from a in _employee.Addresses select a.PostalAddressLine2).SingleOrDefault(),
                            PostLine3 = (from a in _employee.Addresses select a.PostalAddressLine3).SingleOrDefault(),
                            PostCode = (from a in _employee.Addresses select a.PostalCode).SingleOrDefault(),


                        };
                        return rst;
                    }
                    else
                    {
                        return new ViewEmployee();
                    }
                }
            }
            catch
            {
                return new ViewEmployee();
            }
        }

        List<ViewEmployee> IEmployeeDB.GetEmployees()
        {
            try
            {
                using (var db = new DB.SelfServiceSQLDBEntities1())
                {
                    return (from a in db.Employees
                            select new ViewEmployee
                            {
                                EmpoloyeeID = a.Id,
                                FirstName = a.FirstName,
                                LastName = a.LastName,
                                Email = a.Email,
                                 Cell = a.Cell,
                                  Title = a.Title,
                                  Gender = a.Gender
                            }).ToList();
                }
            }
            catch
            {
                return new List<ViewEmployee>();
            }
        }
    }
}
