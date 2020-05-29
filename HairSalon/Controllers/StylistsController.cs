using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;
    public StylistsController()
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View("Index");
    }

    public ActionResult Create()
    {
      return View("Create");
    }

    [HttpPost] 
    public ActionResult Create(Stylist stylist)
    {
      return RedirectToAction("Index", "Stylists");
    }

    public ActionResult Details(int id)
    {
      return View("Details", model);
    }

  }
}