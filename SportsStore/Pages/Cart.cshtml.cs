using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStore.Models;
using SportsStore.Infrastucture;

namespace SportsStore.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;

        public CartModel(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(); // before creating the SessionCart class
        }

        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(); // before creating the SessionCart class
            Cart.AddItem(product, 1);
            //HttpContext.Session.SetJson("cart", Cart); // before creating the SessionCart class
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Product.ProductID == productId).Product);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
