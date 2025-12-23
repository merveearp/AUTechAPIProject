using AITech.DataAccess.Context;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.AboutRepositories
{
    public class AboutRepository : IAboutRepository
    {
        private readonly AppDbContext _context;

        public AboutRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<About?> GetAsync()
        {
            return await _context.Abouts.FirstOrDefaultAsync();
        }

        public async Task CreateAsync(About about)
        {
            await _context.Abouts.AddAsync(about);
        }

        public void Update(About about)
        {
            _context.Abouts.Update(about);
        }
    }
}
