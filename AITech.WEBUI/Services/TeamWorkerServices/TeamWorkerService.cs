using AITech.WEBUI.DTOs.SocialDtos;
using AITech.WEBUI.DTOs.TeamWorkersDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.TeamWorkerServices
{
    public class TeamWorkerService : ITeamWorkerService
    {
        private readonly HttpClient _httpClient;

        public TeamWorkerService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }
        public async Task CreateAsync(CreateTeamWorkerDto createDto)
        {
            var jsonContent = JsonConvert.SerializeObject(createDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("teamworkers", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("teamworkers/" + id);
        }

        public async Task<List<ResultTeamWorkerDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("teamworkers");
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ResultTeamWorkerDto>>(jsonContent);
        }

        public async  Task<UpdateTeamWorkerDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("teamworkers/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Ekip Üyesi Bulunamadı");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UpdateTeamWorkerDto>(jsonContent);
        }

        public async Task UpdateAsync(UpdateTeamWorkerDto updateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(updateDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("teamworkers", content);
        }
    }
}
