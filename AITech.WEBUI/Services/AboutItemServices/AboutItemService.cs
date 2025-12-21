using AITech.WEBUI.DTOs.AboutItemDtos;
using AITech.WEBUI.DTOs.CategoryDtos;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace AITech.WEBUI.Services.AboutItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _httpClient;
        public AboutItemService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateAboutItemDto aboutItemDto)
        {
            var jsonContent = JsonConvert.SerializeObject(aboutItemDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("aboutItems", content);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultAboutItemDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("aboutItems");
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultAboutItemDto>>(jsonContent);

                 
        }

        public async Task<UpdateAboutItemDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("aboutItems/"+ id);
            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("Item Bulunamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UpdateAboutItemDto>(jsonContent);


        }

        public async Task UpdateAsync(UpdateAboutItemDto aboutItemDto)
        {
            var jsonContent = JsonConvert.SerializeObject(aboutItemDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("aboutItems", content);
        }
    }
}


