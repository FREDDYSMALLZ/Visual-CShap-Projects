using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApplication.Models
{
    using System.ComponentModel.DataAnnotations;
    [Bind(Exclude = "Id")]
    public class Login
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "User name is Required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [StringLength(12, ErrorMessage = "The {0} must be at least {2} characters long. ", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password and Password Confirmation does not match")]
        public string ConfirmPassword { get; set; }
    }
}