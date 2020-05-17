using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Web;

namespace Phase_1.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        public double price { get; set; }
        [DisplayName("Upload Image")]
        public string image { get; set; }
        public string description { get; set; }
        [ForeignKey("Category")]
        public int category_id { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        public virtual Category Category { get; set; }
    }
}