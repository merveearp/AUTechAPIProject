using AITech.DTO.ContactDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.ContactServices
{
    public interface IContactService
    {
        Task<ResultContactDto> TGetAsync();
        Task TCreateAsync(CreateContactDto contactDto);
        Task TUpdateAsync(UpdateContactDto contactDto);

    }
}
