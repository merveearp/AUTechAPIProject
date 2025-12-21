using AITech.Business.Services.AboutItemServices;
using AITech.DTO.AboutItemDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutItemsController(IAboutItemService _aboutItemService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items =await _aboutItemService.TGetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _aboutItemService.TGetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutItemDto aboutItemDto)
        {
            await _aboutItemService.TCreateAsync(aboutItemDto);
            return Ok("Yeni item oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutItemDto aboutItemDto)
        {
            await _aboutItemService.TUpdateAsync(aboutItemDto);
            return Ok("Item Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutItemService.TDeleteAsync(id);
            return Ok("Item silindi");
        }
    }
}
