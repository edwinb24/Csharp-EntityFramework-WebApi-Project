using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        //Navigation Property
        public ICollection<Order> Orders { get; set; }
    }

}