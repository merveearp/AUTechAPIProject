using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.UILayout
{
    public class _LayoutNavbarComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
