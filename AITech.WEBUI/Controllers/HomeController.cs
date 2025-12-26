using AITech.WEBUI.DTOs.UserMessageDtos;
using AITech.WEBUI.Models;
using AITech.WEBUI.Services.ProjectService;
using AITech.WEBUI.Services.UserMessageServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AITech.WEBUI.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IUserMessageService _userMessageService;

        public HomeController(IProjectService projectService, IUserMessageService userMessageService)
        {
            _projectService = projectService;
            _userMessageService = userMessageService;
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

        [HttpGet]
        public async Task<IActionResult> CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateUserMessageDto createDto)
        {
            if (!ModelState.IsValid)
            {
                TempData["UserMessageError"] =
                    "Lütfen zorunlu alanlarý doldurunuz.";
                return RedirectToAction("Index", "Home");
            }

            await _userMessageService.CreateAsync(createDto);

            TempData["UserMessageSuccess"] =
                "Mesajýnýz alýnmýþtýr. En kýsa sürede sizinle iletiþime geçilecektir.";

            return RedirectToAction("Index", "Home");
        }


    }
}
