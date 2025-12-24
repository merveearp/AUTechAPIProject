using AITech.WEBUI.DTOs.FeatureDtos;
using AITech.WEBUI.DTOs.SocialDtos;
using AITech.WEBUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    public class FeatureController(IFeatureService _featureService) : Controller
    {
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            var entities = await _featureService.GetAllAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createDto)
        {
            await _featureService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFeature(int id)
        {
            var value = await _featureService.GetByIdAsync(id);

            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateDto)
        {
            await _featureService.UpdateAsync(updateDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _featureService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
