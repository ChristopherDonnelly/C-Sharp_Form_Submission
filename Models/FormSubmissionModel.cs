using System.ComponentModel.DataAnnotations;
 
namespace Form_Submission.Models
{
    public class User
    {
        [Required(ErrorMessage="First Name required!")]
        [MinLength(4, ErrorMessage="First Name must be greater than 4 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Last Name required!")]
        [MinLength(4, ErrorMessage="Last Name must be greater than 4 characters!")]
        public string LastName { get; set; }
 
        [Required(ErrorMessage="Age required!")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage="Enter only positive numeric number(s)!")]
        public string Age { get; set; }

        [Required(ErrorMessage="Email required!")]
        [EmailAddress(ErrorMessage="Please ensure that you have entered a valid email address!")]
        public string Email { get; set; }
 
        [Required(ErrorMessage="Password required!")]
        [MinLength(8, ErrorMessage="Password must be greater than 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}