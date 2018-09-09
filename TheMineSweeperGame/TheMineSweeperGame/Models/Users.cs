using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheMineSweeperGame.Models
{
    public class Users
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string Email { get; set; }



        [Required]
        [DisplayName("Confirm Email")]
        [Compare("Email", ErrorMessage = "Please Confirm your email address")] 
        public string ConfirmEmail { get; set; }

        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Date of Birth ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DateOfBirth { get; set; }


        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimum of 6 characters are required ")]
        public string Password { get; set; }


        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Please Confirm your password")]
        public string ConfirmPassword { get; set; }
    }
}