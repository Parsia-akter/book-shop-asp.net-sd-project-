using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Review1
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string WriteReview { set; get; }
        [Required]
        public string GetUserId { set; get; }
        [ForeignKey("UserId")]
        public ApplicationUsercs ApplicationUsercs { set; get; }

       // [Required]
       // public int GetProductId { set; get; }
       // [ForeignKey("ProductId")]
        //public Product Product { set; get; }
    }
}
