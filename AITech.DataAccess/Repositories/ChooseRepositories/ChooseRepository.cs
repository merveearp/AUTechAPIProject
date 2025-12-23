using AITech.DataAccess.Context;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;


namespace AITech.DataAccess.Repositories.ChooseRepositories
{
    public class ChooseRepository : IChooseRepository
    {
        private readonly AppDbContext _context;

        public ChooseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async  Task CreateAsync(Choose choose)
        {
            await _context.Chooses.AddAsync(choose);
        }

        public async Task<Choose?> GetAsync()
        {
            return await _context.Chooses.FirstOrDefaultAsync();
        }

        public void Update(Choose choose)
        {
             _context.Chooses.Update(choose);
        }
    }
}
