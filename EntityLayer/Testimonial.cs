﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
