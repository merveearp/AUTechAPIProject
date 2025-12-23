
using AITech.WEBUI.DTOs.TestimonialDtos;

namespace AITech.WEBUI.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();
        Task<UpdateTestimonialDto> GetByIdAsync(int id);
        Task CreateAsync(CreateTestimonialDto createDto);
        Task UpdateAsync(UpdateTestimonialDto updateDto);
        Task DeleteAsync(int id);
    }
}
