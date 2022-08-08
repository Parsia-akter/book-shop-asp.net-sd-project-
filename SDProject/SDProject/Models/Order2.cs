using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Order2
    {
        public Order2()
        {
            OrderDetails2 = new List<OrderDetails2>();
        }
        public int Id { get; set; }
        public string OrderId { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string UserId { set; get; }
        [ForeignKey("UserId")]
        public ApplicationUsercs ApplicationUser { set; get; }
        public virtual List<OrderDetails2> OrderDetails2 { set; get; }
    }
}
