using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    [Table("Product")]
    public class Product
    {
        public int ID { get; set; }
        [StringLength(30),Column(TypeName ="varchar")]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}