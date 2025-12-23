using AITech.Business.Services.AboutServices;
using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DTO.AboutDtos;
using AITech.DTO.AboutItemDtos;
using AITech.DTO.ChooseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService _aboutService)  : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entity = await _aboutService.TGetAsync();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto createDto)
        {
            await _aboutService.TCreateAsync(createDto);
            return Ok("About oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto updateDto)
        {
            await _aboutService.TUpdateAsync(updateDto);
            return Ok("About Güncellendi");
        }


    }
}
