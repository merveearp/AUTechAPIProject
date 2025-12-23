using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AITech.WEBUI.ViewComponents.UILayout
{
    public class _LayoutHeadComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
