using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SelfService.Business.BaseData
{
    public static class UIElements
    {
        public static class DropDownData
        {
            public static List<SelectListItem> Title()
            {
                SelfService.Data.Inteface.IBaseDB baseDB = new SelfService.Data.Abstract.BaseDB();
                //var rst = baseDB.GetTitles();
                //return (from a in rst
                //        select new SelectListItem
                //        {
                //            Text = a.Description,
                //            Value = a.Value
                //        }).ToList();
                List<SelectListItem> options = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Mr", Value = "Mr" },
                    new SelectListItem { Text = "Ms", Value = "Ms" },
                    new SelectListItem { Text = "Mrs", Value = "Mrs" },
                    new SelectListItem { Text = "Dr", Value = "Dr" },
                    new SelectListItem { Text = "Prof", Value = "Mrs" }
                };
                return options;
            }
            public static List<SelectListItem> Gender()
            {
                SelfService.Data.Inteface.IBaseDB baseDB = new SelfService.Data.Abstract.BaseDB();
                var rst = baseDB.GetGenders();
                return (from a in rst
                        select new SelectListItem
                        {
                            Text = a.Description,
                            Value = a.Value
                        }).ToList();
            }
            public static List<SelectListItem> Department()
            {
                SelfService.Data.Inteface.IBaseDB baseDB = new SelfService.Data.Abstract.BaseDB();
                var rst = baseDB.GetDepartments();
                return (from a in rst
                        select new SelectListItem
                        {
                            Text = a.Description,
                            Value = a.ID.ToString()
                        }).ToList();
            }
        }
    }
}
