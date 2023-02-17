using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageSliderUrl { get; set; }
    }
}
