using AITech.WEBUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeAboutComponent(IAboutService _aboutService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _aboutService.GetAsync();
            return View(entities);
        }
    }
}
