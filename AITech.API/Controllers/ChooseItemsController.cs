using AITech.Business.Services.ChooseItemServices;
using AITech.DTO.ChooseItemDtos;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChooseItemsController(IChooseItemService _chooseItemService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _chooseItemService.TGetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _chooseItemService.TGetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChooseItemDto createItemDto)
        {
            await _chooseItemService.TCreateAsync(createItemDto);
            return Ok("Yeni item oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateChooseItemDto updateItemDto)
        {
            await _chooseItemService.TUpdateAsync(updateItemDto);
            return Ok("Item Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _chooseItemService.TDeleteAsync(id);
            return Ok("Item silindi");
        }
    }
}
