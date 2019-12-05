using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW7.Models
{
    public class User : Admin
    {
        [MinLength(11)]
        public string PhoneNumber { get; set; }
    }
}