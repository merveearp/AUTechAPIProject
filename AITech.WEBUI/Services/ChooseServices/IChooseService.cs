using AITech.WEBUI.DTOs.CategoryDtos;
using AITech.WEBUI.DTOs.ChooseDtos;

namespace AITech.WEBUI.Services.ChooseServices
{
    public interface IChooseService
    {
        Task<List<ResultChooseDto>> GetAllAsync();
        Task<UpdateChooseDto> GetByIdAsync(int id);
        Task CreateAsync(CreateChooseDto chooseDto);
        Task UpdateAsync(UpdateChooseDto chooseDto);
        Task DeleteAsync(int id);
    }
}
