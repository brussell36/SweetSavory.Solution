using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetSavory.Models;
using System.Threading.Tasks;
using SweetSavory.ViewModels;

namespace SweetSavory.Controllers
{
  public class AccountController : Controller
  {
    private readonly SweetSavoryContext _db;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    public AccountController(SweetSavoryContext db, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
      _db = db;
      _userManager = userManager;
      _signInManager = signInManager;
    }

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var AppUser = new AppUser { UserName = model.Email };
      Identity result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
    }
  }
}