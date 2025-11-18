using AITech.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories
{
    public interface IGenericRepository<Tentity> where Tentity : BaseEntity
    {
        Task<IList<Tentity>> GetAllAsync();
        Task<Tentity> GetByIdAsync(int id);
        Task CreateAsync(Tentity entity);
        Task UpdateAsync(Tentity entity);
        Task DeleteAsync(int id);
    }
}
