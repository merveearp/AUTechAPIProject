
using AITech.WEBUI.DTOs.ContactDtos;

namespace AITech.WEBUI.Services.ContactServices
{
    public interface IContactService
    {
        Task<ResultContactDto?> GetAsync();
        Task UpdateAsync(UpdateContactDto updateDto);
        Task CreateAsync(CreateContactDto createDto);
    }
}
