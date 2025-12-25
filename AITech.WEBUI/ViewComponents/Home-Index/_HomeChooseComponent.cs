using AITech.WEBUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeChooseComponent(IChooseService _chooseService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _chooseService.GetAsync();
            return View(entities);
        }
    }
}
