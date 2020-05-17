using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phase_1.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        public int number_of_products { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}