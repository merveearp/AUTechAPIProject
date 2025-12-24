using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.BannerRepositories
{
    public class BannerRepository : IBannerRepository
    {
        private readonly AppDbContext _context;

        public BannerRepository(AppDbContext context)
        {
            _context = context;
        }

       
        public async Task CreateAsync(Banner banner)
        {
            await _context.Banners.AddAsync(banner);
        }

        public async  Task<Banner?> GetAsync()
        {
            return await _context.Banners.FirstOrDefaultAsync();
        }

        public void Update(Banner banner)
        {
            _context.Banners.Update(banner);
        }
    }
}
