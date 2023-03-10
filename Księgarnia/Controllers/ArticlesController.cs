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
    public class ArticlesController : Controller
    {
        private readonly MyDbContext _context;

        public ArticlesController(MyDbContext context)
        {
            _context = context;
        }

        [Route("Articles/GetCategory/{id}")]
        public IActionResult GetCategory(int id)
        {

            var articles = _context.Articles
            .Where(a => a.Category.Id == id)
             .Select(a =>
                 new Article()
                 {
                     Id = a.Id,
                     Name = a.Name,
                     Price = a.Price,
                     CategoryId = a.CategoryId,
                     FilePath = a.FilePath,
                     Amount = a.Amount,
                     Detail = a.Detail,
                     Publisher = a.Publisher,
                     Author = a.Author,
                     Producer = a.Producer
                 }
                 )
             .ToList();

            



            return View("Views/Articles/Index.cshtml", articles);


        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            ViewBag.koszykInfo = HttpContext.Session.GetInt32("cartItem");
            HttpContext.Session.SetInt32("cartItem", 0);
            ViewData["fav"] = HttpContext.Session.GetString("addF");
            ViewData["col"] = HttpContext.Session.GetString("color");
            ViewData["b"] = HttpContext.Session.GetString("brak");
            HttpContext.Session.SetString("brak", " ");

            HttpContext.Session.SetString("addF", "");
            HttpContext.Session.SetString("color", "");
            var myDbContext = _context.Articles.Include(a => a.Category);
            return View(await myDbContext.ToListAsync());
        }

        public async Task<IActionResult> IndexBooks()
        {
            var myDbContext = _context.Articles.Include(a => a.Category);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }
            if (HttpContext.Session.GetInt32("client") == null)
            {
                return View("Views/Favourities/FavouritesResult.cshtml");
            }

            return View(article);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,CategoryId,Amount,Detail,Publisher,Author,Producer,FilePath")] Article article)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
            return View(article);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,CategoryId,Amount,Detail,Publisher,Author,Producer,FilePath")] Article article)
        {
            if (id != article.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", article.CategoryId);
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
