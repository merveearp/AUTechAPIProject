using AITech.Business.Services.BannerServices;
using AITech.DTO.BannerDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IBannerService _bannerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var banners = await _bannerService.TGetAsync();
            return Ok(banners);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto createDto)
        {
            await _bannerService.TCreateAsync(createDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerDto updateDto)
        {
            await _bannerService.TUpdateAsync(updateDto);
            return NoContent();
        }

 
    }

}
