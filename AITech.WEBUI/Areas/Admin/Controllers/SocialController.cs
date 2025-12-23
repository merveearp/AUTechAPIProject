using AITech.WEBUI.DTOs.FAQDtos;
using AITech.WEBUI.DTOs.SocialDtos;
using AITech.WEBUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SocialController(ISocialService _socialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var entities = await _socialService.GetAllAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocial(CreateSocialDto createDto)
        {
            await _socialService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSocial(int id)
        {
            var value = await _socialService.GetByIdAsync(id);

            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateSocial(UpdateSocialDto updateDto)
        {
            await _socialService.UpdateAsync(updateDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteSocial(int id)
        {
            await _socialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
