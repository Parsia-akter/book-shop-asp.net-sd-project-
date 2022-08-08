using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class ApplicationUsercs:IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      
        public string Name { get; set; }
        public bool Seller { set; get; }
    }
}
