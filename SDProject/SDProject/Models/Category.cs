using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Categories { get; set; }
    }
}
