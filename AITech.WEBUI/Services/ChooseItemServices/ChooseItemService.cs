using AITech.WEBUI.DTOs.ChooseItemDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.ChooseItemServices
{
    public class ChooseItemService : IChooseItemService
    {
        private readonly HttpClient _httpClient;

        public ChooseItemService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateChooseItemDto chooseDto)
        {
            var jsonContent = JsonConvert.SerializeObject(chooseDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("ChooseItems", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("ChooseItems/" + id);
        }

        public async Task<List<ResultChooseItemDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("ChooseItem");
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultChooseItemDto>>(jsonContent);
        }

        public async Task<UpdateChooseItemDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("ChooseItems/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Seçenek Bulunamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UpdateChooseItemDto>(jsonContent);
        }

        public async Task UpdateAsync(UpdateChooseItemDto chooseDto)
        {
            var jsonContent = JsonConvert.SerializeObject(chooseDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("ChooseItems", content);
        }
    }
}
