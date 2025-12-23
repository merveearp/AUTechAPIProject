using AITech.Business.Services.ChooseServices;
using AITech.DTO.ChooseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoosesController(IChooseService _chooseService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entities = await _chooseService.TGetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _chooseService.TGetByIdAsync(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseDto createChoose)
        {
             await _chooseService.TCreateAsync(createChoose);
            return Ok("Seçenek Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateChooseDto updateChoose)
        {
            await _chooseService.TUpdateAsync(updateChoose);
            return Ok("Seçenek Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _chooseService.TDeleteAsync(id);
            return Ok("Seçenek Silindi");
        }
    }
}
