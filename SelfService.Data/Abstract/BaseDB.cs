using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfService.Data.Inteface;
using SelfService.Model;

namespace SelfService.Data.Abstract
{
   public sealed class BaseDB : Inteface.IBaseDB
    {
        List<BaseModel.DropDownModel> IBaseDB.GetDepartments()
        {
            try
            {
                using (var db = new SelfService.Data.DB.SelfServiceSQLDBEntities1())
                {
                    return (from a in db.Departments.Where(a => a.Active == true)
                            select new BaseModel.DropDownModel
                            {
                                Description = a.Description,
                                ID = a.Id,
                                Value = a.Description
                            }).ToList();
                }
            }
            catch
            {
                return new List<BaseModel.DropDownModel>();
            }
        }

        List<BaseModel.DropDownModel> IBaseDB.GetGenders()
        {
            try
            {

                using (var db = new SelfService.Data.DB.SelfServiceSQLDBEntities1())
                {
                    return (from a in db.Genders
                            select new BaseModel.DropDownModel
                            {
                                Description = a.Description,
                                ID = a.Id,
                                Value = a.Description
                            }).ToList();
                }
            }
            catch
            {
                return new List<BaseModel.DropDownModel>();
            }
        }

        List<BaseModel.DropDownModel> IBaseDB.GetTitles()
        {
            try
            {
                using (var db = new SelfService.Data.DB.SelfServiceSQLDBEntities1())
                {
                    return (from a in db.Titles.Where(a => a.Active == true)
                            select new BaseModel.DropDownModel
                            {
                                Description = a.Description,
                                ID = a.Id,
                                Value = a.Description
                            }).ToList();
                }
            }
            catch
            {
                return new List<BaseModel.DropDownModel>();
            }
        }


    }
}
