using AITech.Business.Services.UserMessageServices;
using AITech.DTO.TestimonialDtos;
using AITech.DTO.UserMessages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMessagesController(IUserMessageService _userMessage) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _userMessage.TGetAllAsync();
            return Ok(entities);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _userMessage.TGetByIdAsync(id);
            if (entity is null)
            {
                return BadRequest("İlgili mesaj bulunamadı!");
            }
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserMessageDto createMessage)
        {
            await _userMessage.TCreateAsync(createMessage);
            return Created();

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserMessageDto updateMessage)
        {
            await _userMessage.TUpdateAsync(updateMessage);
            return Ok("Kullanıcıya Geri dönüş yapıldı");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userMessage.TDeleteAsync(id);
            return NoContent();

        }
    }
}
