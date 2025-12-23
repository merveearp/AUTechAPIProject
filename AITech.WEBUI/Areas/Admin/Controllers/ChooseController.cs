using AITech.WEBUI.DTOs.AboutDtos;
using AITech.WEBUI.DTOs.ChooseDtos;
using AITech.WEBUI.DTOs.ChooseItemDtos;
using AITech.WEBUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ChooseController(IChooseService _chooseService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var entities = await _chooseService.GetAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseDto createDto)
        {
            await _chooseService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _chooseService.GetAsync();

            if (value == null)
                return View(new UpdateChooseDto());

            return View(new UpdateChooseDto
            {
                Id = value.Id,
                Title = value.Title,
                Description = value.Description,
                ImageUrl = value.ImageUrl
            });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(UpdateChooseDto updateDto)
        {
            if (!ModelState.IsValid)
                return View(updateDto);

            await _chooseService.UpdateAsync(updateDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
