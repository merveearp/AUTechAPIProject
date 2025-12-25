using AITech.WEBUI.DTOs.ChooseItemDtos;
using AITech.WEBUI.Services.ChooseItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeChooseItemComponent :ViewComponent
    {
        private readonly IChooseItemService _chooseItemService;
        
        public _HomeChooseItemComponent(IChooseItemService chooseItemService)
        {
            _chooseItemService = chooseItemService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _chooseItemService.GetAllAsync();
            return View(entities ?? new List<ResultChooseItemDto>());
        }
    }
}
