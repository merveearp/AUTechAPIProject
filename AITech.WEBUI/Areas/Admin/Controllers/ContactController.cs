
using AITech.WEBUI.DTOs.ContactDtos;
using AITech.WEBUI.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController(IContactService _contactService) : Controller
    {
       
        public async Task<IActionResult> Index()
        {
            var entities = await _contactService.GetAsync();
            return View(entities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactDto createDto)
        {
            await _contactService.CreateAsync(createDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var value = await _contactService.GetAsync();

            if (value == null)
                return View(new UpdateContactDto());

            return View(new UpdateContactDto
            {
                Id = value.Id,
                Adress = value.Adress,
                Email = value.Email,
                Phone = value.Phone
            });
        }


        [HttpPost]
        public async Task<IActionResult> Update(UpdateContactDto updateDto)
        {
            if (!ModelState.IsValid)
                return View(updateDto);

            await _contactService.UpdateAsync(updateDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
