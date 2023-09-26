using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWD2.Models
{
    public class auther
    {
        public int id { get; set; }
        [MaxLength(50)]

        public string userName { get; set; }
        [MaxLength(50)]

        public string Password { get; set; }
        [MaxLength(50)]

        public string email { get; set; }
        public int age { get; set; }
		[Column(TypeName = "image")]
		public string? img { get; set; }
        public virtual ICollection<post> Posts { get; set; }


	}
}
