using AITech.Business.Services.TeamWorkerServices;
using AITech.DTO.CategoryDtos;
using AITech.DTO.TeamWorkersDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamWorkersController(ITeamWorkerService _teamWorkerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _teamWorkerService.TGetAllAsync();
            return Ok(categories);
        }


        //localhost:7000/api/categories/2
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _teamWorkerService.TGetByIdAsync(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamWorkerDto createDto)
        {
            await _teamWorkerService.TCreateAsync(createDto);
            return Ok("Yeni Ekip Üyesi Oluşturuldu!");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTeamWorkerDto updateDto)
        {
            await _teamWorkerService.TUpdateAsync(updateDto);
            return Ok("Ekip Üyesi Güncellendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _teamWorkerService.TDeleteAsync(id);
            return Ok("Ekip Üyesi Silindi!");
        }
    }
}
