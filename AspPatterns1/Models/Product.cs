using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspPatterns1.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public int Category { get; set; }
        public string ProductName { get; set; }
    }
}