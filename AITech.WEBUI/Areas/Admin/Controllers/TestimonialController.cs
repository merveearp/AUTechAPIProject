using AITech.WEBUI.DTOs.TestimonialDtos;
using AITech.WEBUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class TestimonialController (ITestimonialService _testimonialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var entities = await _testimonialService.GetAllAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createDto)
        {
            await _testimonialService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var value = await _testimonialService.GetByIdAsync(id);

            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateDto)
        {
            await _testimonialService.UpdateAsync(updateDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
