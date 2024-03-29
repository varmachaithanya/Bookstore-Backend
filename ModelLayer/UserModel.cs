using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class UserModel
    {
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First name start with Cap and Should have minimum 3 character")]
        [RegularExpression(@"^[A-Z]{1}[a-zA-Z ]{2,}$", ErrorMessage = "First name is not valid")]
        public string FullName { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(pattern: @"^[0-9a-zA-Z]+([-_+.]?[0-9a-zA-Z]+)*@[0-9a-zA-Z]+\.[a-zA-Z]{2,4}([-][a-zA-Z]{2,3})?$", ErrorMessage = "EMAIL ID NOT IN VALID FORMAT....")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "PASSWORD IS REQUIRED")]
        [RegularExpression(pattern: @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Mobile Number is Required")]
        [RegularExpression(pattern: @"^[0-9]{10}", ErrorMessage="Mobile number must contains 10 numbers")]
        public long Mobile {  get; set; }
    }
}
