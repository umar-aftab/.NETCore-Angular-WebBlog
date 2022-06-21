using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(10, ErrorMessage = "Must be at least 10-30 chars")]
        [MaxLength(30, ErrorMessage = "Must be at least 10-30 chars")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Must be at least 30 chars")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }
    }
}
