using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDProject.Data;
using SDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SDProject.Areas.Visitor.Controllers
{
    [Area("Visitor")]
    public class CustomerController : Controller
    {
        private ApplicationDbContext _db;

       

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }

       

      
       
       

        public IActionResult home()
        {
            var images = _db.SliderImages.FirstOrDefault(c => c.Id == 1);
            var products = _db.Product.Include(c => c.Category).ToList();
            CatProduct obj = new CatProduct();
            obj.AllProductViewModel = products;
            obj.ImagesViewModel = images;
            return View(obj);
        }

        public ActionResult details(int? id)

        {
            if(id==null)
            {
                return NotFound();
            }
            var product = _db.Product.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
           
            if (product == null)
            {
                return NotFound();
            }

            var category = _db.Category.ToList();
            CatProduct obj = new CatProduct();
            obj.OneProductViewModel = product;
            obj.AllCategoryViewModel = category;
            obj.userLists = _db.ApplicationUsercs.ToList().Where(c => c.Seller == true);
            obj.Allreviewtest = _db.ReviewTest.ToList().Where(c=>c.GetProductId==id);
            return View(obj);;
        }
      
        public IActionResult slider()
        {
            return View(_db.Category.ToList());
        }
       

        public IActionResult shop()
        {
            CatProduct obj = new CatProduct();
            obj.AllCategoryViewModel = _db.Category.ToList();
            obj.userLists = _db.ApplicationUsercs.ToList().Where(c => c.Seller == true);
            return View(obj);
        }

       
        public IActionResult ProductsOfCategory(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var cat = _db.Category.ToList();
            var products = _db.Product.Include(c => c.Category).ToList().Where(c=>c.CategoryId==id);
            if(products==null)
            {
                TempData["save"] = "No products";
                return NotFound();
            }
            CatProduct obj = new CatProduct();
            obj.AllCategoryViewModel = cat;
            obj.AllProductViewModel = products;
            obj.userLists = _db.ApplicationUsercs.ToList().Where(c => c.Seller == true);
            return View(obj);
        }

        public IActionResult contact()
        {
            var cat = _db.Category.ToList();
            CatProduct obj = new CatProduct();
            obj.AllCategoryViewModel = cat;
            obj.userLists = _db.ApplicationUsercs.ToList().Where(c => c.Seller == true);

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> contact(Contact contact)
        {
            CatProduct obj = new CatProduct();
            obj.contact = contact;
            if (ModelState.IsValid)
            {
                _db.Contact.Add(obj.contact);
                await _db.SaveChangesAsync();
                TempData["save"] = "Message send successfully";
                return RedirectToAction(nameof(home));
                


            }
            return View();

        }
      
       public ActionResult Review(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            var product = _db.Product.Find(id);
            // ViewBag.proid = id;
            if (product==null)
            { return NotFound(); }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Review(Review1 review)
        {


            if (ModelState.IsValid)
            {

                _db.Review1.Add(review);
                //_db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Review1 ON;");
                await _db.SaveChangesAsync();




                return RedirectToAction(nameof(details));



            }

            return View();

        }

      
        public IActionResult Reviewss()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

       public async Task<IActionResult> Reviewss(ReviewTest review)
        {
           
            if (ModelState.IsValid)
            {

                
                review.GetProductId = 7;
                _db.ReviewTest.Add(review);
                await _db.SaveChangesAsync();
                TempData["save"] = "Review added successfully";
                return RedirectToAction(nameof(Reviewss));



            }

            return View();

        }
       
        public IActionResult about()
        {
            CatProduct obj = new CatProduct();
            obj.AllCategoryViewModel = _db.Category.ToList();
            obj.userLists = _db.ApplicationUsercs.ToList().Where(c => c.Seller == true);
            obj.About = _db.About.ToList().Where(c => c.Id == 1);

            return View(obj);
        }
       
        public IActionResult ProductsOfSeller(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cat = _db.Category.ToList();
            var products = _db.Product.Include(c => c.ApplicationUser).ToList().Where(c => c.UserId == id);
           
            CatProduct obj = new CatProduct();
            obj.AllCategoryViewModel = cat;
            obj.AllProductViewModel = products;
            obj.userLists = _db.ApplicationUsercs.ToList().Where(c => c.Seller == true);
            return View(obj);
        }
        public IActionResult AllProducts()
        {
            var cat = _db.Category.ToList();
            var products = _db.Product.Include(c => c.ApplicationUser).Include(c => c.Category).ToList();

            CatProduct obj = new CatProduct();
            obj.AllCategoryViewModel = cat;
            obj.AllProductViewModel = products;
            obj.userLists = _db.ApplicationUsercs.ToList().Where(c => c.Seller == true);
            return View(obj);
        }

    }
}
