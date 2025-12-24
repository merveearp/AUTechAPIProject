using AITech.WEBUI.DTOs.ProjectDtos;
using AITech.WEBUI.Services.CategoryServices;
using AITech.WEBUI.Services.ProjectService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController(IProjectService _projectService,ICategoryService _categoryService) : Controller
    {
        private async Task GetCategoriesAsync()
        {
            var categoryList = await _categoryService.GetAllAsync();
            ViewBag.categories = (from category in categoryList
                                  select new SelectListItem
                                  {
                                      Text = category.Name,
                                      Value = category.Id.ToString()
                                  }).ToList();
                
        }
        public async Task<IActionResult> Index()
        {
            var projects = await _projectService.GetAllAsync();
            return View(projects);
        }


        [HttpGet]
        public async Task<IActionResult> CreateProject()
        {
            await GetCategoriesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDto createProjectDto)
        {
            if(!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(createProjectDto);
            }
            await _projectService.CreateAsync(createProjectDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProject(int id)
        {
            await GetCategoriesAsync();
            var value = await _projectService.GetByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProject(UpdateProjectDto updateProjectDto)
        {

            await GetCategoriesAsync();
            await _projectService.UpdateAsync(updateProjectDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProject(int id)
        {
            await _projectService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        
        public async Task<IActionResult> MakeActive(int id)
        {
            await _projectService.MakeActiveAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakePassive(int id)
        {
            await _projectService.MakePassiveAsync(id);
            return RedirectToAction("Index");
        }

    }
}
