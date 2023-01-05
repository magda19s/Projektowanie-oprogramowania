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
    public class FavouritiesController : Controller
    {
        private readonly MyDbContext _context;

        public FavouritiesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Favourities
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("client") == null)
            {
                return View("Views/Favourities/FavouritesResult.cshtml");
            }
            int client = (int)HttpContext.Session.GetInt32("client");
            var myDbContext = _context.Favourities.Include(f => f.Article).Where(f => f.ClientId == client);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Favourities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favourities = await _context.Favourities
                .Include(f => f.Article)
                .Include(f => f.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favourities == null)
            {
                return NotFound();
            }

            return View(favourities);
        }

        // GET: Favourities/Create
        public IActionResult Create()
        {
            ViewData["ArticleId"] = new SelectList(_context.Articles, "Id", "Id");
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id");
            return View();
        }

        // POST: Favourities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArticleId")] Favourities favourities)
        {

            int client = (int)HttpContext.Session.GetInt32("client");
            if (ModelState.IsValid)
            {
                Favourities fav = new Favourities
                {
                    Id = favourities.Id,
                    ArticleId = favourities.ArticleId,
                    ClientId = client
                };
                _context.Add(fav);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
     
            return View(favourities);
        }

        [Route("Favourities/AddToFavourite/{ArticleId}")]
        public async Task<IActionResult> AddToFavourite(int ArticleId)
        {
            if (HttpContext.Session.GetInt32("client") == null)
            {
                return View("Views/Favourities/FavouritesResult.cshtml");
            }
            int client = (int)HttpContext.Session.GetInt32("client");
            var favr = _context.Favourities.Select(e => e).Where(e => e.ArticleId == ArticleId)
                .Where(e => e.ClientId == client).ToList();

            if (favr.Count == 0)
            {
                if (ModelState.IsValid)
                {
                    Favourities fav = new Favourities
                    {
                        ArticleId = ArticleId,
                        ClientId = client
                    };
                    _context.Add(fav);
                    await _context.SaveChangesAsync();
                    string dodano = "Produkt został dodany do ulubionych.";
                    HttpContext.Session.SetString("addF", dodano);
                    HttpContext.Session.SetString("color", "green");
                }
            }
            else
            {
                string niedodano = "Produkt znajduje się już w ulubionych.";
                HttpContext.Session.SetString("addF", niedodano);
                HttpContext.Session.SetString("color", "red");
            }


            return RedirectToAction("Index", "Articles");
        }
        // GET: Favourities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favourities = await _context.Favourities.FindAsync(id);
            if (favourities == null)
            {
                return NotFound();
            }
            ViewData["ArticleId"] = new SelectList(_context.Articles, "Id", "Id", favourities.ArticleId);
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", favourities.ClientId);
            return View(favourities);
        }

        // POST: Favourities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClientId,ArticleId")] Favourities favourities)
        {
            if (id != favourities.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favourities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavouritiesExists(favourities.Id))
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
            ViewData["ArticleId"] = new SelectList(_context.Articles, "Id", "Id", favourities.ArticleId);
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", favourities.ClientId);
            return View(favourities);
        }

        // GET: Favourities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favourities = await _context.Favourities
                .Include(f => f.Article)
                .Include(f => f.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favourities == null)
            {
                return NotFound();
            }

            return View(favourities);
        }

        // POST: Favourities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var favourities = await _context.Favourities.FindAsync(id);
            _context.Favourities.Remove(favourities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavouritiesExists(int id)
        {
            return _context.Favourities.Any(e => e.Id == id);
        }
    }
}
