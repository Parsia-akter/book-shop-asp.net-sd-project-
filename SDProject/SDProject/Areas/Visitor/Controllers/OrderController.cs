using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Helpers;
using SDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Areas.Visitor.Controllers
{
    [Area("Visitor")]

    public class OrderController : Controller
    {
        private ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Checkout()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Order2 anOrder)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if(cart!=null)
            {
                foreach(var data in cart)
                {
                    OrderDetails2 orderDetails = new OrderDetails2();
                    orderDetails.ProductId = data.Product.Id;
                    anOrder.OrderDetails2.Add(orderDetails);
                }
            }
            anOrder.OrderId = GetOrderNo();
            _db.Order2.Add(anOrder);
            await _db.SaveChangesAsync();
            TempData["save"] = "Order done successfully";
            //HttpContext.Session.Set("cart", null);
            return View();
        }
        public string GetOrderNo()
        {
            int rowcount = _db.Order2.ToList().Count + 1;
            return rowcount.ToString("000");
        }
    }
}