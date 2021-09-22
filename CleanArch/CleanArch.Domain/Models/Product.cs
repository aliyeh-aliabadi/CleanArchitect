using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
