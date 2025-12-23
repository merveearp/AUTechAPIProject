using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.AboutRepositories
{
    public interface IAboutRepository
    {
        Task<About?> GetAsync();
        Task CreateAsync(About about);
        void Update(About about);

    }
}
