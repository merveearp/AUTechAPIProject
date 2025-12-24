using AITech.WEBUI.DTOs.AboutDtos;
using AITech.WEBUI.DTOs.BannerDtos;
using AITech.WEBUI.DTOs.ChooseDtos;
using AITech.WEBUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerService _bannerService) : Controller
    {


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var entities = await _bannerService.GetAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto createDto)
        {
            await _bannerService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _bannerService.GetAsync();

            if (value == null)
                return View(new UpdateAboutDto());

            return View(new UpdateBannerDto
            {
                Id = value.Id,
                Title = value.Title,
                Description = value.Description,
                ImageUrl = value.ImageUrl
                
            });
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateBannerDto updateDto)
        {
            if (!ModelState.IsValid)
                return View(updateDto);

            await _bannerService.UpdateAsync(updateDto);
            return RedirectToAction(nameof(Index));
        }


    }
}
