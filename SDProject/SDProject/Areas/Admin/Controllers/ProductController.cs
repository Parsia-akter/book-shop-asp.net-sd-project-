using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SDProject.Data;
using SDProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _db;
        [Obsolete]
        private IHostingEnvironment _he;

        [Obsolete]
        public ProductController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }
        public IActionResult Index()
        {
            return View(_db.Product.Include(c => c.Category).Include(c=>c.ApplicationUser).ToList());
        }

       
       

        //create get action method

        public ActionResult Create()
        {
            ViewData["productTypeId"] = new SelectList(_db.Category.ToList(), "Id", "Categories");
            ViewData["UserId"] = new SelectList(_db.ApplicationUsercs.ToList().Where(c=>c.Seller==true), "Id", "Name");
            return View();
        }

        //create post action method

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create(Product products, IFormFile image)
        {
            if (ModelState.IsValid)

            {
                var searchProduct = _db.Product.FirstOrDefault(c => c.Name == products.Name);
                if (searchProduct != null)
                {
                    ViewBag.message = "This book already exists";
                    ViewData["productTypeId"] = new SelectList(_db.Category.ToList(), "Id", "Categories");
                    ViewData["UserId"] = new SelectList(_db.ApplicationUsercs.ToList().Where(c => c.Seller == true), "Id", "Name");
                    return View(products);
                }

                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "images/" + image.FileName;
                }
                if (image == null)
                {
                    products.Image = "images/avatar.png";
                }
                _db.Product.Add(products);
                await _db.SaveChangesAsync();
                TempData["save"] = "Saved successfully";
                return RedirectToAction(nameof(Index));


            }
            return View(products);

        }

        //edit get action method

        public ActionResult Edit(int? id)
        {
            ViewData["productTypeId"] = new SelectList(_db.Category.ToList(), "Id", "Categories");
            ViewData["UserId"] = new SelectList(_db.ApplicationUsercs.ToList().Where(c => c.Seller == true), "Id", "Name");
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Product.Include(c => c.Category).Include(c=>c.ApplicationUser).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        
        }
        //edit post action method

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Edit(Product products, IFormFile image)
        {
            if (ModelState.IsValid)

            {
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "images/" + image.FileName;
                }
                if (image == null)
                {
                    products.Image = "images/avatar.png";
                }
                _db.Product.Update(products);
                await _db.SaveChangesAsync();
                TempData["save"] = "Updated successfully";
                return RedirectToAction(nameof(Index));


            }
            return View(products);

        }
       

        //get delete action

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var products = _db.Product.Include(c => c.Category).Include(c=>c.ApplicationUser).Where(c => c.Id == id).FirstOrDefault();
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }

        [HttpPost]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Product.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _db.Remove(product);
            await _db.SaveChangesAsync();
            TempData["save"] = "Deleted successfully";
            return RedirectToAction(nameof(Index));
        }

    }
}
