using AITech.Business.Services.ChooseServices;
using AITech.DTO.ChooseDtos;
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
            var entity = await _chooseService.TGetAsync();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseDto createDto)
        {
            await _chooseService.TCreateAsync(createDto);
            return Ok("Yeni oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateChooseDto updateDto)
        {
            await _chooseService.TUpdateAsync(updateDto);
            return Ok("Entity Güncellendi");
        }




    }
}
