using AITech.WEBUI.DTOs.AboutItemDtos;
using AITech.WEBUI.DTOs.SocialDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.SocialServices
{
    public class SocialService : ISocialService
    {
        private readonly HttpClient _httpClient;

        public SocialService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }
        public async Task CreateAsync(CreateSocialDto createDto)
        {
            var jsonContent = JsonConvert.SerializeObject(createDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("socials", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("socials/" + id);
        }

        public async Task<List<ResultSocialDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("socials");
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultSocialDto>>(jsonContent);
        }

        public async  Task<UpdateSocialDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("socials/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Sosyal Medya Bulunamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UpdateSocialDto>(jsonContent);
        }

        public async Task UpdateAsync(UpdateSocialDto updateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(updateDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("socials", content);
        }
    }
}
