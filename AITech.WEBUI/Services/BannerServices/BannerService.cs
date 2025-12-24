using AITech.WEBUI.DTOs.AboutDtos;
using AITech.WEBUI.DTOs.BannerDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _httpClient;

        public BannerService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateBannerDto bannerDto)
        {
            var jsonContent = JsonConvert.SerializeObject(bannerDto);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("banners", content);
        }

        
        public async Task<ResultBannerDto?> GetAsync()
        {
            var response = await _httpClient.GetAsync("Banners/");
            var jsonContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResultBannerDto>(jsonContent);
        }


        public async Task UpdateAsync(UpdateBannerDto bannerDto)
        {
            var jsonContent = JsonConvert.SerializeObject(bannerDto);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("banners", content);
        }


    }
}
