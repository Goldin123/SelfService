using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfService.Model;

namespace SelfService.Data.Inteface
{
    public interface IBaseDB
    {
        List<BaseModel.DropDownModel> GetTitles();
        List<BaseModel.DropDownModel> GetDepartments();
        List<BaseModel.DropDownModel> GetGenders();
    }
}
