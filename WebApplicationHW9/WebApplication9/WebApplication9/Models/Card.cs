using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    public class Card
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CardHolder { get; set; }
        public string DateExpire { get; set; }
        public int CVV { get; set; }
    }
}
