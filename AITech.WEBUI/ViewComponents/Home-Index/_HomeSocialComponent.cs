using AITech.WEBUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeSocialComponent(ISocialService _socialService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _socialService.GetAllAsync();
            return View(entities);
        }
    }
}
