using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDProject.Data;
using SDProject.Helpers;
using SDProject.Models;
using SDProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Areas.Visitor.Controllers
{
    [Area("Visitor")]
    public class CartController : Controller
    {
        private ApplicationDbContext _db;



        public CartController(ApplicationDbContext db)
        {
            _db = db;
        }
        public Product find(int id)
        {

            var prod = _db.Product.Include(c => c.Category).Where(c => c.Id == id).FirstOrDefault();
            return prod;

        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }

        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public IActionResult Buy(int id)
        {
            
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = _db.Product.Include(c => c.Category).Where(c => c.Id == id).FirstOrDefault(), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = _db.Product.Include(c => c.Category).Where(c => c.Id == id).FirstOrDefault(), Quantity = 1 });

                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            if (index != -1)
            {
                cart[index].Quantity--;
                if(cart[index].Quantity==0)
                {
                    cart.RemoveAt(index);

                }
            }
           
          
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
    }
}
