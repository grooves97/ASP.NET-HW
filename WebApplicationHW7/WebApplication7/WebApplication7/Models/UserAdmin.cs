using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class UserAdmin : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}