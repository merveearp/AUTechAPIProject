using AITech.WEBUI.DTOs.TeamWorkersDtos;

namespace AITech.WEBUI.Services.TeamWorkerServices
{
    public interface ITeamWorkerService
    {
        Task<List<ResultTeamWorkerDto>> GetAllAsync();
        Task<UpdateTeamWorkerDto> GetByIdAsync(int id);
        Task CreateAsync(CreateTeamWorkerDto createDto);
        Task UpdateAsync(UpdateTeamWorkerDto updateDto);
        Task DeleteAsync(int id);
    }
}
