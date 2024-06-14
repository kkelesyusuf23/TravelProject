using CityTravelProject.EntityLayer.Concrete;
using CityTravelProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.Controllers
{
    [Authorize]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            var appUser = new AppUser()
            {
                Id = registerViewModel.UserId,
                Name = registerViewModel.Name,
                Email = registerViewModel.Email,
                Surname = registerViewModel.Surname,
                UserName = registerViewModel.UserName,
                City = registerViewModel.City,
                BirthDay = registerViewModel.BirthDay
            };
            var result = await _userManager.CreateAsync(appUser, registerViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return View();
        }
    }
}
