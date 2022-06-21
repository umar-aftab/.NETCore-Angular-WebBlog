using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage="Username is required")]
        [MinLength(5,ErrorMessage = "Must be at least 5-20 chars")]
        [MaxLength(20,ErrorMessage = "Must be at least 5-20 chars")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Must be at least 10-50 chars")]
        [MaxLength(50, ErrorMessage = "Must be at least 10-50 chars")]
        public string Password { get; set; }
    }
}
