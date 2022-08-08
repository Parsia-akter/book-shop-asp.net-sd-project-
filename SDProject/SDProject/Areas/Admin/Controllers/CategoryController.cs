using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Category.ToList());
        }
        //create get action method

        public ActionResult Create()
        {
            return View();
        }

        //create post action method

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(category);
                await _db.SaveChangesAsync();
                TempData["save"] = "Saved successfully";
                return RedirectToAction(nameof(Index));


            }
            return View(category);

        }


        //edit get action method

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _db.Category.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //edit post action method

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Update(category);
                await _db.SaveChangesAsync();
                TempData["save"] = "Updated successfully";
                return RedirectToAction(nameof(Index));


            }
            return View(category);

        }

       

        //delete get action method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _db.Category.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //delete post action method

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int? id,Category productTypes)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != productTypes.Id)
            {
                return NotFound();
            }

            var category = _db.Category.Find(id);

            if (category == null)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                _db.Category.Remove(category);
                await _db.SaveChangesAsync();
                TempData["save"] = "Deleted successfully";
                return RedirectToAction(nameof(Index));


            }
            return View(productTypes);

        }

    }
}
