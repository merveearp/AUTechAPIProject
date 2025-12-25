using AITech.WEBUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeAboutItemComponent(IAboutItemService _aboutItemService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _aboutItemService.GetAllAsync();
            return View(entities);
        }
    }
}
