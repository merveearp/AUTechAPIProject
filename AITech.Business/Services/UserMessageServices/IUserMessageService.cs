using AITech.Business.Services.GenericServices;
using AITech.DTO.UserMessages;
using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.UserMessageServices
{
    public interface IUserMessageService 
    {
        Task<IList<ResultUserMessageDto>> TGetAllAsync();
        Task<ResultUserMessageDto> TGetByIdAsync(int id);
        Task TCreateAsync(CreateUserMessageDto entity);
        Task TDeleteAsync(int id);
        Task TUpdateAsync(UpdateUserMessageDto entity);


    }
}
