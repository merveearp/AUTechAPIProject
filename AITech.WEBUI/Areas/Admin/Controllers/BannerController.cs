using AITech.WEBUI.DTOs.BannerDtos;
using AITech.WEBUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerService _bannerService) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var banners = await _bannerService.GetAllAsync();
            return View(banners);
        }

        public IActionResult CreateBanner()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        {
            await _bannerService.CreateAsync(createBannerDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateBanner(int id)
        {
            var banner = await _bannerService.GetByIdAsync(id);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            await _bannerService.UpdateAsync(updateBannerDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBanner(int id)
        {
            await _bannerService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> MakeActive(int id)
        {
            await _bannerService.MakeActiveAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakePassive(int id)
        {
            await _bannerService.MakePassiveAsync(id);
            return RedirectToAction("Index");
        }

    }
}
