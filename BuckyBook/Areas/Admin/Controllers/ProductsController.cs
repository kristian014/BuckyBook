#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuckyBook.Data;
using BuckyBook.Models;
using BuckyBook.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;

namespace BuckyBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment webHostEnviroment;
        private readonly IMapper mapper;
        

        public ProductsController(IMapper mapper, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnviroment)
        {
            this.unitOfWork = unitOfWork;
            this.webHostEnviroment = webHostEnviroment;
            this.mapper = mapper;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index(string searchString)
        {
            return View(await unitOfWork.Product.GetAllProduct(searchString));
        }

        // GET: Admin/Products/Details/5

        /*
         *  public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await unitOfWork.Product.
                .Include(p => p.Category)
                .Include(p => p.CoverType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

         * */

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ProductVM productVM = new ProductVM();
            productVM.CategoryList = unitOfWork.Category.GetAllCategories();
            productVM.CoverTypeList = unitOfWork.CoverType.GetAllCoverTypes();
          
            return View(productVM);
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                product.ImageUrl = saveImageToRootPath(file, product.ImageUrl);
               await unitOfWork.Product.AddAsync(product);
                TempData["success"] = "Product created successfully";
                return RedirectToAction(nameof(Index));
            }
               
            var productVM = mapper.Map<ProductVM>(product);
           return View(productVM);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await unitOfWork.Product.GetProductWithId(id);
            
            if (product == null)
            {
                return NotFound();
            }
            var productVM = mapper.Map<ProductVM>(product);
            productVM.CategoryList = unitOfWork.Category.GetAllCategories();
            productVM.CoverTypeList = unitOfWork.CoverType.GetAllCoverTypes();
            
            return View(productVM);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product, IFormFile? file)
        {
         
            if (ModelState.IsValid)
            {
                product.ImageUrl = saveImageToRootPath(file, product.ImageUrl);
                try
                {
                    await unitOfWork.Product.UpdateProductAsync(product);
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await unitOfWork.Product.Exists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var productVM = mapper.Map<ProductVM>(product);
            TempData["success"] = "Product updated successfully";
            return View(productVM);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await unitOfWork.Product.GetProductWithId(id);
            if (product == null)
            {
                return NotFound();
            }
            var productVM = mapper.Map<ProductVM>(product);
            return View(productVM);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await unitOfWork.Product.GetProductWithId(id);
            if (product == null)
            {
                return NotFound();
            }

            var oldImagePath = Path.Combine(webHostEnviroment.WebRootPath, product.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                // if it does delete it
                System.IO.File.Delete(oldImagePath);
            }
            await unitOfWork.Product.DeleteAsync(id);
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction(nameof(Index));
        }

        private void isImageUrlExist(string imageUrl, string rootPath)
        {
            if(imageUrl != null)
            {
                var oldImagePath = Path.Combine(rootPath, imageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    // if it does delete it
                    System.IO.File.Delete(oldImagePath);
                }
            }
        }

        private string saveImageToRootPath(IFormFile? file, string imageUrl)
        {
            //string imageUrl = "";
            string wwwRootPath = webHostEnviroment.WebRootPath;
            if (file != null)
            {
                // we have an image 
                string fileName = Guid.NewGuid().ToString();
                // fine the location where the file needs to be uploaded 
                var FileUploads = Path.Combine(wwwRootPath, @"images\products");
                var extension = Path.GetExtension(file.FileName);

                isImageUrlExist(imageUrl, wwwRootPath);

                // use a new file stream to copy the file
                using (var fileStream = new FileStream(Path.Combine(FileUploads, fileName + extension), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                imageUrl = @"\images\products\" + fileName + extension;
            }

            return imageUrl;
        }
     
    }
}
