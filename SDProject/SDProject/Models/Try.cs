using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Try
    {
        public int Id { set; get; }
        [Required]
        public string UserReview { set; get; }
        [Required]
        public string UserId { set; get; }
        [ForeignKey("UserId")]
        public ApplicationUsercs ApplicationUser { set; get; }
        public int GetProductId { set; get; }
        [ForeignKey("GetProductId")]
        public Product Product { set; get; }
        public int Rating { set; get; }
        
    }
}
