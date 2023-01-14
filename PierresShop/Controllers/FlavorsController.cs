using Microsoft.AspNetCore.Mvc;
using PierresShop.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierresShop.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly PierresShopContext _db;

        public FlavorsController(PierresShopContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Flavors.ToList());
        }
    }
}