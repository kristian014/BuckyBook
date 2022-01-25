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
    public class CoverTypesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CoverTypesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: CoverTypes
        public async Task<IActionResult> Index()
        {
            return View(await unitOfWork.CoverType.GetAllAsync());
        }

        // GET: CoverTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var coverType = await unitOfWork.CoverType.GetAsync(id);
            if (coverType == null)
            {
                return NotFound();
            }

            return View(coverType);
        }

        // GET: CoverTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CoverTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] CoverType coverType)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.CoverType.AddAsync(coverType);
                return RedirectToAction(nameof(Index));
            }
            return View(coverType);
        }

        // GET: CoverTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           
            var coverType = await unitOfWork.CoverType.GetAsync(id);
            if (coverType == null)
            {
                return NotFound();
            }
            return View(coverType);
        }

        // POST: CoverTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] CoverType coverType)
        {
            if (id != coverType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await unitOfWork.CoverType.UpdateAsync(coverType);
                 
                }
                catch (DbUpdateConcurrencyException)
                {
                  
                    if (!await unitOfWork.CoverType.Exists(coverType.Id))
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
            return View(coverType);
        }

        // GET: CoverTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var coverType = await unitOfWork.CoverType.GetAsync(id);
         
            if (coverType == null)
            {
                return NotFound();
            }

            return View(coverType);
        }

        // POST: CoverTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
          await unitOfWork.CoverType.DeleteAsync(id);
           return RedirectToAction(nameof(Index));
        }
    }
}
