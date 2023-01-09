﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Księgarnia.Data;
using Księgarnia.Models;

namespace Księgarnia.Controllers
{
    public class DeliveriesController : Controller
    {
        private readonly MyDbContext _context;

        public DeliveriesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Deliveries
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Deliveries.Include(d => d.Address).Include(d => d.Method).Include(d => d.ParcelLocker);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Deliveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries
                .Include(d => d.Address)
                .Include(d => d.Method)
                .Include(d => d.ParcelLocker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // GET: Deliveries/Create
        public IActionResult Create(int? id)
        {
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id");
            ViewData["DeliveryMethodId"] = new SelectList(_context.Methods, "Id", "Id");
            ViewData["ParcelLockerId"] = new SelectList(_context.ParcelLockers, "Id", "Address");
            return View();
        }

        // POST: Deliveries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ParcelLockerId")] Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delivery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", delivery.AddressId);
            ViewData["DeliveryMethodId"] = new SelectList(_context.Methods, "Id", "Id", delivery.DeliveryMethodId);
            ViewData["ParcelLockerId"] = new SelectList(_context.ParcelLockers, "Id", "Id", delivery.ParcelLockerId);
            return View(delivery);
        }

        // GET: Deliveries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries.FindAsync(id);
            if (delivery == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", delivery.AddressId);
            ViewData["DeliveryMethodId"] = new SelectList(_context.Methods, "Id", "Id", delivery.DeliveryMethodId);
            ViewData["ParcelLockerId"] = new SelectList(_context.ParcelLockers, "Id", "Id", delivery.ParcelLockerId);
            return View(delivery);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,Date,ParcelLockerId,DeliveryMethodId,AddressId")] Delivery delivery)
        {
            if (id != delivery.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(delivery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryExists(delivery.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", delivery.AddressId);
            ViewData["DeliveryMethodId"] = new SelectList(_context.Methods, "Id", "Id", delivery.DeliveryMethodId);
            ViewData["ParcelLockerId"] = new SelectList(_context.ParcelLockers, "Id", "Id", delivery.ParcelLockerId);
            return View(delivery);
        }

        // GET: Deliveries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries
                .Include(d => d.Address)
                .Include(d => d.Method)
                .Include(d => d.ParcelLocker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // POST: Deliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var delivery = await _context.Deliveries.FindAsync(id);
            _context.Deliveries.Remove(delivery);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryExists(int id)
        {
            return _context.Deliveries.Any(e => e.Id == id);
        }
    }
}
