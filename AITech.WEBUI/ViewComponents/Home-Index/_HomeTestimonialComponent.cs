using AITech.WEBUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeTestimonialComponent(ITestimonialService _testimonialService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _testimonialService.GetAllAsync();
            return View(entities);
        }
    }
}
