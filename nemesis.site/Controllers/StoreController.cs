using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Nemesis.Site.Models;
using Nemesis.Core;

namespace Nemesis.Site.Controllers
{
    public class StoreController : Controller
    {
        // SHOULD THIS BE HERE????
        Repository repo;
        public StoreController()
        {
            repo = new Repository();
        }

        [HttpGet]
        public IActionResult List(string Postcode)
        {
            if (Postcode != null)
                return View(new StoreListViewModel(repo.Stores.Where(s => s.Postcode.ToLower().StartsWith(Postcode.ToLower()))));
            else
                return View(new StoreListViewModel(repo.Stores));
        }

        [HttpGet]
        public IActionResult Detail(string Id)
        {
            return View(new StoreDetailViewModel(repo.Stores.First(s => s.Id.Equals(Id))));
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
