using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW7.Models
{
    public class Admin : Entity
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}