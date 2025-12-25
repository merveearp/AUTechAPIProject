using AITech.WEBUI.Services.FAOServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeFAQComponent(IFAQService _fAQService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _fAQService.GetAllAsync();
            return View(entities);
        }
    }
}

