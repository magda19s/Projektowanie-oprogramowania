using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Księgarnia.Data;
using Księgarnia.Models;
using Microsoft.AspNetCore.Http;

namespace Księgarnia.Controllers
{
    public class DeliveryMethodsController : Controller
    {
        private readonly MyDbContext _context;

        public DeliveryMethodsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryMethods
        public async Task<IActionResult> Index()
        {
            //if (HttpContext.Session.GetInt32("client") == null)
            //{
              //  return View("Views/Favourities/FavouritesResult.cshtml");
            //}
            return View(await _context.Methods.ToListAsync());
        }

        // GET: DeliveryMethods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMethod = await _context.Methods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryMethod == null)
            {
                return NotFound();
            }

            return View(deliveryMethod);
        }

        // GET: DeliveryMethods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryMethods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] DeliveryMethod deliveryMethod)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryMethod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryMethod);
        }

        // GET: DeliveryMethods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMethod = await _context.Methods.FindAsync(id);
            if (deliveryMethod == null)
            {
                return NotFound();
            }
            return View(deliveryMethod);
        }

        // POST: DeliveryMethods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] DeliveryMethod deliveryMethod)
        {
            if (id != deliveryMethod.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryMethod);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryMethodExists(deliveryMethod.Id))
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
            return View(deliveryMethod);
        }

        // GET: DeliveryMethods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryMethod = await _context.Methods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryMethod == null)
            {
                return NotFound();
            }

            return View(deliveryMethod);
        }

        // POST: DeliveryMethods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryMethod = await _context.Methods.FindAsync(id);
            _context.Methods.Remove(deliveryMethod);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryMethodExists(int id)
        {
            return _context.Methods.Any(e => e.Id == id);
        }
    }
}
