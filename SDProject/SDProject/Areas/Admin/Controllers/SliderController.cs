using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class SliderController : Controller
    {
       
            private ApplicationDbContext _db;
            [Obsolete]
            private IHostingEnvironment _he;

            [Obsolete]
            public SliderController(ApplicationDbContext db, IHostingEnvironment he)
            {
                _db = db;
                _he = he;
            }
            public IActionResult Index()
            {
                return View(_db.SliderImages.ToList());
            }




            //create get action method

            public ActionResult Create()
            {
              
                return View();
            }

            //create post action method

            [HttpPost]
            [ValidateAntiForgeryToken]
            [Obsolete]
            public async Task<IActionResult> Create(SliderImages products, IFormFile image)
            {
                if (ModelState.IsValid)

                {
                    

                    if (image != null)
                    {
                        var name = Path.Combine(_he.WebRootPath + "/images", Path.GetFileName(image.FileName));
                        await image.CopyToAsync(new FileStream(name, FileMode.Create));
                        products.Image1 = "images/" + image.FileName;
                        products.Image2 = "images/" + image.FileName;
                        products.Image3 = "images/" + image.FileName;
                        products.Image4 = "images/" + image.FileName;


                }
                if (image == null)
                    {
                        products.Image1 = "images/slide-1.jpg";
                        products.Image2 = "images/slide-2.png";
                        products.Image3 = "images/slide-3.jpeg";
                        products.Image4 = "images/slide-4.jpg";
                }
                    _db.SliderImages.Add(products);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));


                }
                return View(products);

            }

            //edit get action method

            public ActionResult Edit(int? id)
            {
              
                if (id == null)
                {
                    return NotFound();
                }
                var product = _db.SliderImages.FirstOrDefault(c => c.Id == id);
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
            public async Task<IActionResult> Edit(SliderImages products, IFormFile image)
            {
                if (ModelState.IsValid)

                {
                    if (image != null)
                    {
                        var name = Path.Combine(_he.WebRootPath + "/images", Path.GetFileName(image.FileName));
                        await image.CopyToAsync(new FileStream(name, FileMode.Create));
                        products.Image1 = "images/" + image.FileName;
                        products.Image2 = "images/" + image.FileName;
                        products.Image3 = "images/" + image.FileName;
                        products.Image4 = "images/" + image.FileName;
                }
                    if (image == null)
                    {
                    products.Image1 = "images/slide-1.jpg";
                    products.Image2 = "images/slide-2.png";
                    products.Image3 = "images/slide-3.jpeg";
                    products.Image4 = "images/slide-4.jpg";
                }
                    _db.SliderImages.Update(products);
                    await _db.SaveChangesAsync();
                    TempData["save"] = "Updated successfully";
                    return RedirectToAction(nameof(Index));


                }
                return View(products);

            }

        }
    }
