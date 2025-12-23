using AITech.WEBUI.DTOs.ChooseDtos;

namespace AITech.WEBUI.Services.ChooseServices
{
    public interface IChooseService
    {
        Task<ResultChooseDto?> GetAsync();
        Task UpdateAsync(UpdateChooseDto chooseDto);
        Task CreateAsync(CreateChooseDto chooseDto);
    }
}
