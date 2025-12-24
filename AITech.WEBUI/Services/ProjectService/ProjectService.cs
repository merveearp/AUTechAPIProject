using AITech.WEBUI.DTOs.ProjectDtos;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace AITech.WEBUI.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _client;

        public ProjectService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7051/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateProjectDto projectDto)
        {
            var jsonContent = JsonConvert.SerializeObject(projectDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _client.PostAsync("projects", content);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("projects/" + id);
        }

        public async Task<List<ResultProjectDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultProjectDto>>("projects/WithCategories");
        }

        public async Task<UpdateProjectDto> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateProjectDto>("projects/" + id);
        }

        public async Task MakeActiveAsync(int id)
        {
            await _client.PatchAsync("projects/makeActive/" + id, null);
        }

        public async  Task MakePassiveAsync(int id)
        {
            await _client.PatchAsync("projects/makePassive/" + id, null);
        }

        public async Task UpdateAsync(UpdateProjectDto projectDto)
        {
            var jsonContent = JsonConvert.SerializeObject(projectDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _client.PutAsync("projects", content);
        }

    }
}
