using AITech.WEBUI.DTOs.AboutDtos;
using AITech.WEBUI.DTOs.ContactDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _httpClient;
        public ContactService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }
        public async Task CreateAsync(CreateContactDto createDto)
        {
            var jsonContent = JsonConvert.SerializeObject(createDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("Contacts", content);
        }

        public async Task<ResultContactDto?> GetAsync()
        {
            var response = await _httpClient.GetAsync("Contacts/");
            var jsonContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResultContactDto>(jsonContent);
        }

        public async Task UpdateAsync(UpdateContactDto updateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(updateDto);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("Contacts", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("İletişim bilgileri güncellenirken hata oluştu.");
            }
        }
    }
}
