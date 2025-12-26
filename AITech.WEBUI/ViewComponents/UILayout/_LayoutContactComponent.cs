using AITech.WEBUI.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.UILayout
{
    public class _LayoutContactComponent(IContactService _contactService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _contactService.GetAsync();
            return View(entities);
        }
    }
}
