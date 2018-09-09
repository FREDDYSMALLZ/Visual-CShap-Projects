using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    public class Users
    {
        [Required(AllowEmptyStrings = false,ErrorMessage = "Please Enter your First Name e.g. John")]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter your Last Name e.g. Doe")]
        [StringLength(30, MinimumLength = 3)]
        public string  LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your Email address")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string  Email { get; set; }

        [Required]
        [Compare("Email", ErrorMessage = "Please Confirm your email address")]
        [DisplayName("Confirm Email")]
        public string ConfirmEmail { get; set; }

        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DateOfBirth { get; set; }


        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimum of 6 characters are required ")]
        public string PassWord { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Please Confirm your password")]
        public string ConfirmPassword { get; set; }
    }

}