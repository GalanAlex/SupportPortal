using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportPortal.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Theme { get; set; }
        public int PersonId { get; set; }
        public Person Contact { get; set; }
        public string ContactName { get; set; }
    }
}
