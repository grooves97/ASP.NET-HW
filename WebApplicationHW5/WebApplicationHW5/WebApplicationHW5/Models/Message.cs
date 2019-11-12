using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHW5.Models
{
    public class Message
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Text { get; set; }
    }
}