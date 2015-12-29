using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerDetailsDto
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        public List<Order> Orders { get; set; }
    }
}