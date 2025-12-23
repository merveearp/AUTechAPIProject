using AITech.Business.Services.FAQServices;
using AITech.DTO.FAQDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController(IFAQService _fAQService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _fAQService.TGetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _fAQService.TGetByIdAsync(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFAQDto createFAQ)
        {
            await _fAQService.TCreateAsync(createFAQ);
            return Ok("Soru kalıbı oluşturuldu ");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFAQDto updateFAQ)
        {
            await _fAQService.TUpdateAsync(updateFAQ);
            return Ok("Soru Kalıbı Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _fAQService.TDeleteAsync(id);
            return Ok("Soru Kalıbı Silindi");
        }
    } 
}
