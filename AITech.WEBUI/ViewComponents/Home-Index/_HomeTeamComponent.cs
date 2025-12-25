using AITech.WEBUI.Services.TeamWorkerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.ViewComponents.Home_Index
{
    public class _HomeTeamComponent(ITeamWorkerService _teamWorker) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entities = await _teamWorker.GetAllAsync();
            return View(entities);
        }
    }
}
