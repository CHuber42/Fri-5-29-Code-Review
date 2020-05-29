using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;
    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View("Index", model);
    }

    public ActionResult Create()
    {
      return View("Create");
    }

    [HttpPost] 
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylists");
    }

    public ActionResult Details(int id)
    {
      Stylist foundStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      foundStylist.Clients = _db.Clients.Where(client => client.StylistId == id).ToList();
      return View("Details", foundStylist);
    }

  }
}