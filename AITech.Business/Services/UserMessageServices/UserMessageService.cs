using AITech.DataAccess.Repositories.UserMessageRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.TeamWorkersDtos;
using AITech.DTO.UserMessages;
using AITech.Entity.Entities;
using Mapster;

namespace AITech.Business.Services.UserMessageServices
{
    public class UserMessageService(IUserMessageRepository _userMessage, IUnitOfWork _unitOfWork) : IUserMessageService
    {
        public async Task TCreateAsync(CreateUserMessageDto entity)
        {
            var value = entity.Adapt<UserMessage>();
            await _userMessage.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _userMessage.GetByIdAsync(id);
            if (value == null)
            {
                throw new Exception("Mesaj Bulunamadı");
            }
            _userMessage.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultUserMessageDto>> TGetAllAsync()
        {
            var values = await _userMessage.GetAllAsync();
            return values.Adapt<IList<ResultUserMessageDto>>();
        }

        public async Task<ResultUserMessageDto> TGetByIdAsync(int id)
        {
            var value = await _userMessage.GetByIdAsync(id);
            return value.Adapt<ResultUserMessageDto>();
        }

        public async Task TUpdateAsync(UpdateUserMessageDto dto)
        {
            var value = await _userMessage.GetByIdAsync(dto.Id);

            if (value == null)
                throw new Exception("Mesaj bulunamadı");

            if (value.IsCalled)
                return;

            _userMessage.UpdateIsCalled(value);
            await _unitOfWork.SaveChangesAsync();
        }


    }
}
