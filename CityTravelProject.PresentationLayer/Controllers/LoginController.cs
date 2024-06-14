using CityTravelProject.EntityLayer.Concrete;
using CityTravelProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if (result.Succeeded)
            {
                bool isLoggedIn = User.Identity.IsAuthenticated;
                ViewData["IsLoggedIn"] = isLoggedIn;

                if (isLoggedIn)
                {
                    ViewData["AppUserName"] = model.UserName; // Use the username from the model
                }

                return RedirectToAction("Index", "UIDefault");
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            ViewData["IsLoggedIn"] = false;
            ViewData["AppUserName"] = null;

            return RedirectToAction("Index", "UIDefault");
        }
    }
}
