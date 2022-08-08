using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class Contact
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Subject { set; get; }
        [Required]
        public string Message { set; get; }

    }
}
