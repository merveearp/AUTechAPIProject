using AITech.Business.Services.SocialServices;
using AITech.DTO.FeatureDtos;
using AITech.DTO.SocialDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialsController(ISocialService _socialService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entities = await _socialService.TGetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _socialService.TGetByIdAsync(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSocialDto createSocial)
        {
            await _socialService.TCreateAsync(createSocial);
            return Ok("Yeni Sosyal Medya Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSocialDto updateSocial)
        {
            await _socialService.TUpdateAsync(updateSocial);
            return Ok("Sosyal Medya Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _socialService.TDeleteAsync(id);
            return Ok("Sosyal Medya Silindi");
        }
    }
}
