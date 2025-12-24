using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.BannerRepositories
{
    public interface IBannerRepository 
    {
        Task<Banner?> GetAsync();
        Task CreateAsync(Banner banner);
        void Update(Banner banner);


    }
}
