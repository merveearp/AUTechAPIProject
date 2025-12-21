using AITech.WEBUI.DTOs.BannerDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _httpClient;//Fields

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

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("banners/" + id);
        }

        public async Task<List<ResultBannerDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("banners");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Başlık Listesi alınamadı!");

            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBannerDto>>(jsonContent);
            return values;

        }

        public async Task<UpdateBannerDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("banners/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Başlık bulunamadı!! ");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UpdateBannerDto>(jsonContent);

        }

        public async Task UpdateAsync(UpdateBannerDto bannerDto)
        {
            var jsonContent = JsonConvert.SerializeObject(bannerDto);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("banners", content);
        }

        public async Task MakeActiveAsync(int id)
        {
            await _httpClient.PatchAsync("banners/makeActive/"+id, null);

        }

        public async Task MakePassiveAsync(int id)
        {
            await _httpClient.PatchAsync("banners/makePassive/" + id, null);
        }

    }
}
