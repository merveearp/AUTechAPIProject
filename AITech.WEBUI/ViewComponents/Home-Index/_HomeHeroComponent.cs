using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home
{
    public class _HomeHeroComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
