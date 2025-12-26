using AITech.WEBUI.Services.GeminiServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GeminiController(IGeminiService _geminiService) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> Index(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                return Json(new { answer = "Lütfen bir mesaj yazın." });

            var response = await _geminiService.GetGeminiDataAsync(prompt);
            return Json(new { answer = response });
        }
    }
}
