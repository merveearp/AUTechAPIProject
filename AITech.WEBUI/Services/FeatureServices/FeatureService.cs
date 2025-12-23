using AITech.WEBUI.DTOs.AboutItemDtos;
using AITech.WEBUI.DTOs.ChooseDtos;
using AITech.WEBUI.DTOs.FeatureDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _httpClient;

        public FeatureService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }
        public async Task CreateAsync(CreateFeatureDto featureDto)
        {
            var jsonContent = JsonConvert.SerializeObject(featureDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("features", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("features/" + id);
        }

        public async  Task<List<ResultFeatureDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("features");
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonContent);
        }

        public async  Task<UpdateFeatureDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("features/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Servis Bulunamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UpdateFeatureDto>(jsonContent);
        }

        public async  Task UpdateAsync(UpdateFeatureDto featureDto)
        {
            var jsonContent = JsonConvert.SerializeObject(featureDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("features", content);
        }
    }
}
