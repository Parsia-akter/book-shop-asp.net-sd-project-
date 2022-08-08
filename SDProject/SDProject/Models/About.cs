using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class About
    {
        public int Id { set; get; }
        [Required]
      
        public string AboutUs { set; get; }
    }
}
