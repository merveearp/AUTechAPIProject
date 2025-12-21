using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home
{
    public class _HomeAboutComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
