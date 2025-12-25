using AITech.WEBUI.Models;
using AITech.WEBUI.Services.ProjectService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AITech.WEBUI.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IProjectService _projectService;

        public HomeController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projectService.GetByIdAsync(id);
            return Json(new
            {
                title = project.Title,
                description = project.Description,
                imageUrl = project.ImageUrl

            });

        }
    }
}
