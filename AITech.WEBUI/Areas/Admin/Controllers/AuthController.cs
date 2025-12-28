using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Logout(string reason = null)
        {
            HttpContext.Session.Remove("JWToken");
            HttpContext.Session.Remove("TokenExpire");

            if (reason == "expired")
            {
                TempData["SessionExpired"] =
                    "Oturum süreniz dolduğu için sistemden çıkış yapıldı.";
            }
            else
            {
                TempData["SessionExpired"] =
                    "Çıkış işlemi başarıyla tamamlandı.";
            }

            return RedirectToAction("Home", "Index");
        }
    }
}
