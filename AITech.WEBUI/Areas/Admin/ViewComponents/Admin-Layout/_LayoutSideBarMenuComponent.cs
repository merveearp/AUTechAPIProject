using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.ViewComponents.Admin_Layout
{
    public class _LayoutSideBarMenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
