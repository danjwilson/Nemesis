using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Nemesis.Site.Models;
using Nemesis.Core;

namespace Nemesis.Site.Controllers
{
    public class ProductController : Controller
    {
        // SHOULD THIS BE HERE????
        Repository repo;
        public ProductController()
        {
            repo = new Repository();
        }

        [HttpGet]
        public IActionResult List(string Postcode = "", string Product = "")
        {
            return View(new ProductStoreListViewModel(repo.ProductStores.Where(p => 
                p.Store.Postcode.ToLower().StartsWith(Postcode.ToLower()) && p.Product.Name.ToLower().Contains(Product.ToLower()))));
        }

        [HttpGet]
        public IActionResult Detail(int Id)
        {
            return View(new ProductDetailViewModel(repo.Products.First(p => p.Id.Equals(Id))));
        }

        [HttpPost]
        public IActionResult Detail(StoreDetailViewModel model)

        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}