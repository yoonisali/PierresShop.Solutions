using Microsoft.AspNetCore.Mvc;
using PierresShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresShop.Controllers
{
  public class HomeController : Controller
  {

    private readonly PierresShopContext _db;

    public HomeController(PierresShopContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.Flavors = new List<Flavor>( _db.Flavors);
      ViewBag.Treats = new List<Treat>( _db.Treats);
      return View( _db.Flavors.ToList());
    }
  }
}