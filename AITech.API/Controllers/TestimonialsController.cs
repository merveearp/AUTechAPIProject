using AITech.Business.Services.TestimonialServices;
using AITech.DTO.ProjectDtos;
using AITech.DTO.TestimonialDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(ITestimonialService _testimonialService ) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await _testimonialService.TGetAllAsync();
            return Ok(projects);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _testimonialService.TGetByIdAsync(id);
            if (project is null)
            {
                return BadRequest("İlgili Referans bulunamadı!");
            }
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto  createTestimonial)
        {
            await _testimonialService.TCreateAsync(createTestimonial);
            return Created();

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTestimonialDto updateTestimonial)
        {
            await _testimonialService.TUpdateAsync(updateTestimonial);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _testimonialService.TDeleteAsync(id);
            return NoContent();

        }
    }
}
