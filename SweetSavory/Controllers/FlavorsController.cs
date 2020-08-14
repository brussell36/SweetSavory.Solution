using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SweetSavory.Models;
using System.Collections.Generic;
using System.Linq;

namespace SweetSavory.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetSavoryContext _db;
    public FlavorsController(SweetSavoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}