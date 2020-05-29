using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace HairSalon.Controllers
{
  public class ClientsControllers : Controller
  {
    private readonly HairSalonContext _db;
    public ClientsControllers(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Create()
    {
      return View("Create");
    }


    [HttpPost]
    public ActionResult Create(Client client)
    {
      return RedirectToAction("Index", "Stylists");
    }
  }
}