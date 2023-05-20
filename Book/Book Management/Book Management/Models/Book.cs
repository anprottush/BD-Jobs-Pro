using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Book_Management.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string BookName { get; set; }
        [StringLength(50)]
        [Required]
        public string PublisherName { get; set; }
        //[StringLength(50)]
        [Required]
        public int PublisherAge { get; set; }
        //[StringLength(50)]
        [Required]
        public int PageNo { get; set; }
        //[StringLength(50)]
        [Required]

        public System.DateTime PublishDate { get; set; }
        [StringLength(50)]
        [Required]
        public string BookType { get; set; }
        //[ForeignKey("Report")]
        //public int SerialNo { get; set; }

        //public virtual Report Report { get; set; }
    }
}