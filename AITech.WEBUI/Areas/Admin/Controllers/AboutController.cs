using AITech.WEBUI.DTOs.AboutDtos;
using AITech.WEBUI.DTOs.ChooseDtos;
using AITech.WEBUI.Services.AboutServices;
using AITech.WEBUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AboutController(IAboutService _aboutService) : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var entities = await _aboutService.GetAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto createDto)
        {
            await _aboutService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _aboutService.GetAsync();

            if (value == null)
                return View(new UpdateAboutDto());

            return View(new UpdateAboutDto
            {
                Id = value.Id,
                Title = value.Title,
                Description = value.Description,
                ImageUrl = value.ImageUrl
            });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(UpdateAboutDto updateDto)
        {
            if (!ModelState.IsValid)
                return View(updateDto);

            await _aboutService.UpdateAsync(updateDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
