using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {
            
            if (userModel.Username == "Laxmi Khanal" &&  userModel.Password == "abc")
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View(" LoginFailure", userModel);
            }
        }
    }
}
