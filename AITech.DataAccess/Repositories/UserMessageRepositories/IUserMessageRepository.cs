using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.UserMessageRepositories
{
    public interface IUserMessageRepository

    {
        Task<IList<UserMessage>> GetAllAsync();
        Task<UserMessage> GetByIdAsync(int id);
        Task CreateAsync(UserMessage userMessage);
        void Delete(UserMessage userMessage);
        void UpdateIsCalled(UserMessage userMessage);
    }
}
