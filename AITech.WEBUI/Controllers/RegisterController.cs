using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Controllers
{
    public class RegisterController : Controller
    {
   
        public IActionResult Register()
        {
            return View();
        }
    }
}
