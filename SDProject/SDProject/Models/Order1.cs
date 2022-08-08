using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Order1
    {
        public Order1()
        {
            OrderDetails1 = new List<OrderDetails1>();
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
        public virtual List<OrderDetails1> OrderDetails1 { set; get; }
    }
}
