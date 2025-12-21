using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home
{
    public class _HomeFeatureComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
