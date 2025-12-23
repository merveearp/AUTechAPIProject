using AITech.WEBUI.DTOs.FAQDtos;
using AITech.WEBUI.Services.FAOServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class FAQController(IFAQService _fAQService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var entities = await _fAQService.GetAllAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult CreateFAQ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFAQ(CreateFAQDto createDto)
        {
            await _fAQService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFAQ(int id)
        {
            var value = await _fAQService.GetByIdAsync(id);

            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateFAQ(UpdateFAQDto updateDto)
        {
            await _fAQService.UpdateAsync(updateDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteFAQ(int id)
        {
            await _fAQService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
