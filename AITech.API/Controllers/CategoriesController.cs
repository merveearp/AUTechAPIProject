using AITech.Business.Services.CategoryServices;
using AITech.DTO.CategoryDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryService _categoryService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.TGetAllAsync();
            return Ok(categories);
        }


        //localhost:7000/api/categories/2
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.TGetByIdAsync(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto createDto)
        {
           await _categoryService.TCreateAsync(createDto);
           return Ok("Kategori Oluşturuldu!");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryDto updateDto)
        {
           await _categoryService.TUpdateAsync(updateDto);
            return Ok("Kategori Güncellendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
           await _categoryService.TDeleteAsync(id);
            return Ok("Kategori Silindi!");
        }
    }
}
