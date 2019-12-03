using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationHW7.ViewModel
{
    public class SettingsViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int RoleId { get; set; }
    }
}