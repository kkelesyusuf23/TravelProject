using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CityTravelProject.EntityLayer.Concrete;
using CityTravelProject.PresentationLayer.Models; // AppUser entity

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
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

                if (result.Succeeded)
                {
                    // Authentication successful, set ViewData for the view
                    ViewData["IsLoggedIn"] = true;

                    return RedirectToAction("Index", "UIDefault"); // Redirect to your home/index page
                }

                // If login fails, add an error to ModelState
                ModelState.AddModelError(string.Empty, "Invalid login attempt");
            }

            // If ModelState is invalid or login fails, return the view with errors
            ViewData["IsLoggedIn"] = false;
            return View(model);
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
