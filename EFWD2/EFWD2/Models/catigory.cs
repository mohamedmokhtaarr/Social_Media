using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWD2.Models
{
    public class catigory
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(100)]

        public string? description { get; set; }
		public virtual ICollection<post> Posts { get; set; }

	}
}
