using AITech.WEBUI.DTOs.ProjectDtos;

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
            await _client.PostAsJsonAsync("projects", projectDto);
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

        public async Task UpdateAsync(UpdateProjectDto projectDto)
        {
            await _client.PutAsJsonAsync("projects" , projectDto);
        }
    }
}
