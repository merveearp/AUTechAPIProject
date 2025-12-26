using AITech.WEBUI.DTOs.UserMessageDtos;
using AITech.WEBUI.Services.UserMessageServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController(IUserMessageService _userMessage) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var messages = await _userMessage.GetAllAsync();
            return View(messages);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateUserMessageDto dto)
        {
            await _userMessage.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> GetMessageDetail(int id)
        {
            var message = await _userMessage.GetByIdAsync(id);
            return PartialView("_MessageDetailModal", message);
        }


    }
}
