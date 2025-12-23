using AITech.WEBUI.DTOs.SocialDtos;
using AITech.WEBUI.DTOs.TeamWorkersDtos;
using AITech.WEBUI.DTOs.TestimonialDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _httpClient;

        public TestimonialService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }
        public async Task CreateAsync(CreateTestimonialDto createDto)
        {
            var jsonContent = JsonConvert.SerializeObject(createDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("testimonials", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("testimonials/" + id);
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("testimonials");
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonContent);
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("testimonials/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Referans Bulunamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UpdateTestimonialDto>(jsonContent);
        }

        public async Task UpdateAsync(UpdateTestimonialDto updateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(updateDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("testimonials", content);
        }
    }
}
