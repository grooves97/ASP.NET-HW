using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHW7.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string AboutMe { get; set; }
        public int RoleId { get; set; }
        public Role RoleName { get; set; }
    }
}