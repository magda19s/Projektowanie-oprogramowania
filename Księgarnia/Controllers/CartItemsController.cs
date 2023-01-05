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
    public class CartItemsController : Controller
    {
        private readonly MyDbContext _context;
        CookieOptions options;


        public CartItemsController(MyDbContext context)
        {
            _context = context;
            options = new CookieOptions();

        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("client") == null)
            {
                return View("Views/Favourities/FavouritesResult.cshtml");
            }
            var cookies = Request.Cookies.Keys;
            if (cookies.Count == 0)
            {
                return View();
            }

            var products = new List<CartItem>();

            foreach (var cookie in cookies)
            {
                int artId;
                if (Int32.TryParse(cookie, out artId))
                {
                    Article article = _context.Articles.Where(a => a.Id == artId).FirstOrDefault();
                    int amount = Int32.Parse(Request.Cookies[cookie]);
                    if (article == null)
                    {
                        TempData["Message"] = "Some products in your shopping cart are not available now";
                        Response.Cookies.Delete(cookie);
                    }
                    else
                    {
                        Category category = _context.Categories.Where(a => a.Id == article.CategoryId).FirstOrDefault();
                        article.Amount = article.Amount - amount;
                        CartItem productsCart = new CartItem()
                        {
                            Id = article.Id,
                            Article = article,
                            Category = category,
                            TotalPrice = Math.Round(amount * article.Price, 4),
                            Amount = amount,
                        };
                        products.Add(productsCart);
                        if (article.Amount == 0)
                        {
                            HttpContext.Session.SetString("brak", "This product is not available");
                        }
                    }
                }

            }
            


            return View(products);
        }

        public async Task<IActionResult> Index2()
        {
            var cookies = Request.Cookies.Keys;
            if (cookies.Count == 0)
            {
                return View();
            }

            var products = new List<CartItem>();

            foreach (var cookie in cookies)
            {
                int artId;
                if (Int32.TryParse(cookie, out artId))
                {
                    Article article = _context.Articles.Where(a => a.Id == artId).FirstOrDefault();
                    int amount = Int32.Parse(Request.Cookies[cookie]);
                    if (article == null)
                    {
                        TempData["Message"] = "Some products in your shopping cart are not available now";
                        Response.Cookies.Delete(cookie);
                    }
                    else
                    {
                        Category category = _context.Categories.Where(a => a.Id == article.CategoryId).FirstOrDefault();
                        article.Amount = article.Amount - amount;
                        CartItem productsCart = new CartItem()
                        {
                            Id = article.Id,
                            Article = article,
                            Category = category,
                            TotalPrice = Math.Round(amount * article.Price, 4),
                            Amount = amount
                        };
                        products.Add(productsCart);
                    }
                }

            }


            return View(products);
        }

        public async Task<IActionResult> Increase(int id)
        {
            string myAmount = Request.Cookies[id.ToString()];
            int value = Int32.Parse(myAmount) + 1;
            Save(id, value);
            return RedirectToAction("Index2");
        }

        public async Task<IActionResult> GetToView(int id)
        {
            
            return View("Views/CartItems/Edit.cshtml");
        }

        public async Task<IActionResult> Decrease(int id)
        {
            string myAmount = Request.Cookies[id.ToString()];
            int newAmount = Int32.Parse(myAmount) - 1;

            if (newAmount == 0)
            {
                Response.Cookies.Delete(id.ToString());
            }
            else
            {
                Save(id, newAmount);
            }
            return RedirectToAction("Index2");

        }

        public IActionResult Delete(int id)
        {
            Response.Cookies.Delete(id.ToString());
            return RedirectToAction("Index2");

        }

        public IActionResult BuyArticle(int id)
        {
            if (HttpContext.Session.GetInt32("client") == null)
            {
                return View("Views/Favourities/FavouritesResult.cshtml");
            }
            string idOfIthem = id.ToString();
            string defaultVal = "1";
            string myAmount = Request.Cookies[idOfIthem];
            if (myAmount == null || myAmount == " ")
            {
                Response.Cookies.Append(id.ToString(), defaultVal, options);
            }
            else
            {
                int value = Int32.Parse(myAmount) + 1;
                Save(id, value);
            }
            HttpContext.Session.SetInt32("cartItem", 1);
            return RedirectToAction("Index", "Articles");
        }

        public void Save(int id, int amount)
        {
            options.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append(id.ToString(), amount.ToString(), options);
        }
    

   
        private bool CartItemExists(int id)
        {
            return _context.CartItem.Any(e => e.Id == id);
        }
    }
}
