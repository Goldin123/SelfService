using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.Model
{
   public class Dashboard
    {
        public int TotalEmplyees { get; set; }
        public int TotalEmployeesAddedToday { get; set; }
        public int TotalMale { get; set; }
        public int TotalFemale { get; set; }
    }
}
