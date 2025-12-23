using AITech.WEBUI.DTOs.AboutItemDtos;
using AITech.WEBUI.DTOs.CategoryDtos;
using AITech.WEBUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AboutItemController(IAboutItemService _aboutItemService ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var entities = await _aboutItemService.GetAllAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult CreateItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(CreateAboutItemDto createDto)
        {
            await _aboutItemService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateItem(int id)
        {
            var value = await _aboutItemService.GetByIdAsync(id);

            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateItem(UpdateAboutItemDto updateDto)
        {
            await _aboutItemService.UpdateAsync(updateDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteItem(int id)
        {
            await _aboutItemService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
