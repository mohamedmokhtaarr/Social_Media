using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWD2.Models
{
    public class post
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string? title { get; set; }
        [MaxLength(100)]

        public string? bref { get; set; }
        [MaxLength(250)]

        public string? desc { get; set; }
        [Column (TypeName ="time")]
        public TimeSpan? time { get; set; }
        [Column(TypeName = "date")]

        public DateTime? date { get; set; }
        [ForeignKey("auther")]
        public int autherId { get; set; }
    
        public virtual auther auther { get; set; }
        [ForeignKey("catigory")]
        public int catId { get; set; }
		[Column(TypeName = "image")]
		public string? img { get; set; }

        public virtual auther Auther { get; set; }
        public virtual catigory Catigory { get; set; }


    }
}
