using AITech.WEBUI.DTOs.SocialDtos;
using AITech.WEBUI.DTOs.TeamWorkersDtos;
using AITech.WEBUI.DTOs.TestimonialDtos;
using AITech.WEBUI.Services.TeamWorkerServices;
using AITech.WEBUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class TeamWorkerController(ITeamWorkerService _teamWorkerService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var entities  = await _teamWorkerService.GetAllAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamWorkerDto createDto)
        {
            await _teamWorkerService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTeam(int id)
        {
            var value = await _teamWorkerService.GetByIdAsync(id);

            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateTeam(UpdateTeamWorkerDto updateDto)
        {
            await _teamWorkerService.UpdateAsync(updateDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _teamWorkerService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
