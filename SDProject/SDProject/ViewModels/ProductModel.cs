using Microsoft.EntityFrameworkCore;
using SDProject.Data;
using SDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.ViewModels
{
    public class ProductModel
    {
        private ApplicationDbContext _db;

        public ProductModel()
        {
        }

        public ProductModel(ApplicationDbContext db)
        {
            _db = db;
        }
       

        public List<Product> _products { get; set; }
       
     
    
    }
}
