using AITech.WEBUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _LayoutServiceComponent(IFeatureService _featureService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _featureService.GetAllAsync();
            return View(entities);
        }
    }
}
