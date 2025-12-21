using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home
{
    public class _HomeServiceComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
