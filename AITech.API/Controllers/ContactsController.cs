using AITech.Business.Services.ContactServices;
using AITech.DTO.AboutDtos;
using AITech.DTO.ContactDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController (IContactService _contactService): ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entity = await _contactService.TGetAsync();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactDto createDto)
        {
            await _contactService.TCreateAsync(createDto);
            return Ok("İletişim bilgisi oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateContactDto updateDto)
        {
            await _contactService.TUpdateAsync(updateDto);
            return Ok("İletişim bilgisi Güncellendi");
        }
    }
}
