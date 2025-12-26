using AITech.WEBUI.DTOs.UserMessageDtos;
using AITech.WEBUI.Models;
using AITech.WEBUI.Services.GeminiServices;
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
        private readonly IGeminiService _geminiService;


        public HomeController(IProjectService projectService, IUserMessageService userMessageService, IGeminiService geminiService)
        {
            _projectService = projectService;
            _userMessageService = userMessageService;
            _geminiService = geminiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string prompt)
        {
            var response = await _geminiService.GetGeminiDataAsync(prompt);
            if (response != null)
            {
                ViewBag.response = response;
            }
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
