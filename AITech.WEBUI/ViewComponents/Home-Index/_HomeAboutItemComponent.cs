using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeAboutItemComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
