using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.Model
{
   public class Result
    {
        public bool Valid { get; set; }
        public int ID { get; set; }
        public string Message { get; set; }
        public string Value { get; set; }
    }
}
