using AITech.WEBUI.DTOs.ChooseItemDtos;

namespace AITech.WEBUI.Services.ChooseItemServices
{
    public interface IChooseItemService
    {
        Task<List<ResultChooseItemDto>> GetAllAsync();
        Task<UpdateChooseItemDto> GetByIdAsync(int id);
        Task CreateAsync(CreateChooseItemDto chooseDto);
        Task UpdateAsync(UpdateChooseItemDto chooseDto);
        Task DeleteAsync(int id);
    }
}
