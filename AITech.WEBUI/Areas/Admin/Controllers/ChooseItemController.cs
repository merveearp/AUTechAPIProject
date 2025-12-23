using AITech.WEBUI.DTOs.ChooseItemDtos;
using AITech.WEBUI.Services.ChooseItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ChooseItemController(IChooseItemService _chooseService ) : Controller
    {
        [Area("Admin")]

        public async Task<IActionResult> Index()
        {
            var entities = await _chooseService.GetAllAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseItemDto createDto)
        {
            await _chooseService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _chooseService.GetByIdAsync(id);

            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> Update(UpdateChooseItemDto updateDto)
        {
            await _chooseService.UpdateAsync(updateDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int id)
        {
            await _chooseService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
