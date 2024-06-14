using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CityTravelProject.EntityLayer.Concrete;
using CityTravelProject.PresentationLayer.Models;
using System.Threading.Tasks;

namespace CityTravelProject.PresentationLayer.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    var userProfile = new UserProfileViewModel
                    {
                        UserName = user.UserName,
                        Email = user.Email,
                        Name = user.Name,
                        Surname = user.Surname,
                        City = user.City,
                        BirthDay = user.BirthDay
                    };

                    return View(userProfile);
                }
            }

            return RedirectToAction("Login", "Index");
        }
    }
}
