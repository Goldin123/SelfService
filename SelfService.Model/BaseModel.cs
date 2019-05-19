using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.Model
{
   public class BaseModel
    {
        public class DropDownModel
        {
            public int ID { get; set; }
            public string Value { get; set; }
            public string Description { get; set; }
        }
    }
}
