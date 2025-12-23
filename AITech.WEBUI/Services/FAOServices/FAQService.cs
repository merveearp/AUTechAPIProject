using AITech.WEBUI.DTOs.FAQDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.FAOServices
{
    public class FAQService : IFAQService
    {
        private readonly HttpClient _httpClient;

        public FAQService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateFAQDto FAQDto)
        {
           var jsonContent = JsonConvert.SerializeObject(FAQDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("FAQs", content);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultFAQDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("FAQs");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<ResultFAQDto>>(jsonContent);
            return content;


        }

        public Task<UpdateFAQDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(UpdateFAQDto FAQDto)
        {
            var jsonContent = JsonConvert.SerializeObject(FAQDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("FAQs", content);
        }
    }
}
