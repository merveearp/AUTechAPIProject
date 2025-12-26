using AITech.WEBUI.DTOs.SocialDtos;
using AITech.WEBUI.DTOs.UserMessageDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.UserMessageServices
{
    public class UserMessageService : IUserMessageService
    {
        private readonly HttpClient _httpClient;

        public UserMessageService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateUserMessageDto createDto)
        {
            var jsonContent = JsonConvert.SerializeObject(createDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("UserMessages", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("UserMessages/" + id);
        }

        public async Task<List<ResultUserMessageDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("UserMessages");
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultUserMessageDto>>(jsonContent);
        }

        public async Task<ResultUserMessageDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("UserMessages/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Mesaj Bulunamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ResultUserMessageDto>(jsonContent);
        }

        public async Task UpdateAsync(UpdateUserMessageDto updateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(updateDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("UserMessages", content);
        }
    }
}
