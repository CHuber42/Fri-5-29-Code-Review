using Microsoft.AspNetCore.Mvc;
using Best_Restaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class ClientsControllers : Controller
  {
    private readonly HairSalonContext db;
    public ClientsControllers()
    {
      _db = db;
    }

    public ActionResult Create()
    {
      return View("Create");
    }

    public ActionResult Create()
    {
      return RedirectToAction("Index", "Stylists");
    }
  }
}