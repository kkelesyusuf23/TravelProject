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
        public async Task<IActionResult> Index(LoginViewModel model)//loginviewmodel(username,password) olmasının sebebi tüm appuser tablosundaki verileri kullanmamış olmak
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if (result.Succeeded)
            {
                bool isLoggedIn = User.Identity.IsAuthenticated;
                ViewData["IsLoggedIn"] = isLoggedIn;

                if (isLoggedIn)
                {
                    ViewData["AppUserName"] = User.Identity.Name; // Kullanıcı adını al
                }
                return RedirectToAction("Index", "UIDefault");
            }
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "UIDefault");
        }
    }
}
