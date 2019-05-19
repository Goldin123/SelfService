using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.Model
{
    public class CustomVariables
    {
        public enum Gender
        {
            [Description("Male")]
            Male = 1,
            [Description("Female")]
            Female = 2,
            [Description("")]
            empty = 0
        }
    }

    public static class CustomVariablesDescription
    {
        public static string ToDescription(this Enum value)
        {
            var da = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return da.Length > 0 ? da[0].Description : value.ToString();
        }
    }
}
