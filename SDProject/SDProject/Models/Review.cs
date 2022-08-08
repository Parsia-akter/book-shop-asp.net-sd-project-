using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Review
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string UserReviewWrite { set; get; }
        [Required]
        public string UserId { set; get; }
       [ForeignKey("UserId")]
        public ApplicationUsercs ApplicationUsercs { set; get; }
        [Required]
        public int ProductId { set; get; }
        [ForeignKey("ProductId")]
        public Product Product { set; get; }

    }
}
