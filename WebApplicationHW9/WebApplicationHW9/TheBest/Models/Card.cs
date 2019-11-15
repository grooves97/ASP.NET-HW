using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBest.Models
{
    public class Card
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public long Date { get; set; }
        public int CVV { get; set; }
    }
}
