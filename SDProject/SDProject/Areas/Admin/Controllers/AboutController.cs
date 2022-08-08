using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SDProject.Data;
using SDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private ApplicationDbContext _db;

        public AboutController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.About.ToList());
        }
        //create get action method

        public ActionResult Create()
        {
            return View();
        }

        //create post action method

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(About about)
        {
            if (ModelState.IsValid)
            {
                _db.About.Add(about);
                await _db.SaveChangesAsync();
            
                return RedirectToAction(nameof(Index));


            }
            return View(about);

        }

        //edit get action method

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var about = _db.About.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        //edit post action method

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(About about)
        {
            if (ModelState.IsValid)
            {
                _db.About.Update(about);
                await _db.SaveChangesAsync();
                TempData["save"] = "Updated successfully";
                return RedirectToAction(nameof(Index));


            }
            return View(about);

        }

        public IActionResult Contact()
        {
            return View(_db.Contact.ToList());
        }
        public IActionResult Seller()
        {
            CatProduct obj = new CatProduct();
            var list = _db.ApplicationUsercs.ToList().Where(c=>c.Seller==true);
           
            obj.userLists = list;
           
            return View(obj);
           
        }

        public IActionResult OrderList()
        {
            CatProduct obj = new CatProduct();
            obj.Order2 = _db.Order2.Include(c => c.ApplicationUser).ToList();
            obj.OrderDetails2 = _db.OrderDetails2.Include(c => c.Item).Include(c => c.Order).ToList();
            return View(obj);
        }

       


    }
}
