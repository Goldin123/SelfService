using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SelfService.Model
{
    public class ViewEmployee
    {
        public int? EmpoloyeeID { get; set; }
        [Required(ErrorMessage = "Enter First Name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter Last Name.")]
        public string LastName { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter Email Address.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Cell Number.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid cell number.")]
        public string Cell { get; set; }
        public string Telephone { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter Physical Address Line 1.")]
        public string PhysicalLine1 { get; set; }
        public string PhysicalLine2 { get; set; }
        public string PhysicalLine3 { get; set; }
        [Required(ErrorMessage = "Enter Physical Code.")]
        public string PhysicalCode { get; set; }
        [Required(ErrorMessage = "Enter Postal Address Line 1.")]
        public string PostLine1 { get; set; }
        public string PostLine2 { get; set; }
        public string PostLine3 { get; set; }
        [Required(ErrorMessage = "Enter Postal Code.")]
        public string PostCode { get; set; }
        public int? DepartmentID { get; set; }

    }

   
}
