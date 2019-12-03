using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationHW7.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Упс не совпали")]
        public string ConfirmPassword { get; set; }
        public string AboutMe { get; set; }
        [Required]
        public int Age { get; set; }
    }
}