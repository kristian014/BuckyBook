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
using Microsoft.AspNetCore.Authorization;
using BuckyBook.Constant;

namespace BuckyBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Admin)]
    public class CompaniesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ApplicationDbContext _context;

        public CompaniesController(IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _context = context;
            this.unitOfWork = unitOfWork;
        }

        // GET: Admin/Companies
        public async Task<IActionResult> Index()
        {
            return View(await unitOfWork.Company.GetAllAsync());
        }

        // GET: Admin/Companies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await unitOfWork.Company.GetAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Admin/Companies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StreetAddress,City,State,PostalCode,PhoneNumber")] Company company)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.Company.AddAsync(company);
                TempData["success"] = "Company created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Admin/Companies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await unitOfWork.Company.GetAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Admin/Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StreetAddress,City,State,PostalCode,PhoneNumber")] Company company)
        {
            if (id != company.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   await unitOfWork.Company.UpdateAsync(company);
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await unitOfWork.Company.Exists(company.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["success"] = "Company Updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Admin/Companies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await unitOfWork.Company.GetAsync(id);
                
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Admin/Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
            await unitOfWork.Company.DeleteAsync(id);
            TempData["success"] = "Company deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
