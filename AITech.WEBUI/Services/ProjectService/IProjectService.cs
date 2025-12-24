using AITech.WEBUI.DTOs.ProjectDtos;

namespace AITech.WEBUI.Services.ProjectService
{
    public interface IProjectService
    {
        Task<List<ResultProjectDto>> GetAllAsync();
        Task<UpdateProjectDto> GetByIdAsync(int id);
        Task CreateAsync(CreateProjectDto ProjectDto);
        Task UpdateAsync(UpdateProjectDto ProjectDto);
        Task DeleteAsync(int id);
        Task MakeActiveAsync(int id);
        Task MakePassiveAsync(int id);
    }
}
