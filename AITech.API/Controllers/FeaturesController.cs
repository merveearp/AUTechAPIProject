using AITech.Business.Services.FeatureServices;
using AITech.DTO.ChooseDtos;
using AITech.DTO.FeatureDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IFeatureService _featureService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entities = await _featureService.TGetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _featureService.TGetByIdAsync(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeatureDto createFeature)
        {
            await _featureService.TCreateAsync(createFeature);
            return Ok("Hizmet Oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFeatureDto updateFeature)
        {
            await _featureService.TUpdateAsync(updateFeature);
            return Ok("Hizmet Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _featureService.TDeleteAsync(id);
            return Ok("Hizmet Silindi");
        }
    }
}
