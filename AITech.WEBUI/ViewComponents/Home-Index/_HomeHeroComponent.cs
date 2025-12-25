using AITech.WEBUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeHeroComponent(IBannerService _bannerService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _bannerService.GetAsync();
            return View(entities);
        }
    }
}
