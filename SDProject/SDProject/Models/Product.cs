using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Product
    {
        public int Id { set; get; }
        [Required]

        public string Name { set; get; }
        [Required]
        public double Price { set; get; }
        public string Image { set; get; }
       
      
        [Required]
        [Display(Name="Category")]
        public int CategoryId { set; get; }
        [ForeignKey("CategoryId")]
      
        public Category Category { set; get; }
        [Required]
        public int Quantity { set; get; }
        [Required]
        public string Author { set; get; }
        [Required]
        public string Description { set; get; }
        [Display(Name="Seller")]
        public string UserId { set; get; }
        [ForeignKey("UserId")]
        public ApplicationUsercs ApplicationUser { set; get; }

    }
}
