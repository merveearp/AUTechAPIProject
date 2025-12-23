using AITech.WEBUI.DTOs.AboutDtos;
using AITech.WEBUI.DTOs.BannerDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _httpClient;
        public AboutService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateAboutDto createDto)
        {
            var jsonContent = JsonConvert.SerializeObject(createDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("Abouts", content);
        }

        public async Task<ResultAboutDto?> GetAsync()
        {
            var response = await _httpClient.GetAsync("Abouts/");
            var jsonContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResultAboutDto>(jsonContent);
        }

        public async  Task UpdateAsync(UpdateAboutDto updateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(updateDto);

            var content = new StringContent(jsonContent,Encoding.UTF8,"application/json" );

            var response = await _httpClient.PutAsync("Abouts", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("About bilgileri kaydedilirken hata oluştu.");
            }

           
        }

       
    }
}
