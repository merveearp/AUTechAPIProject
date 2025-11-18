using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories;
using AITech.Entity.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.GenericRepositories
{
    public class GenericRepository<TEntity>(AppDbContext _context) : IGenericRepository<TEntity> where TEntity : BaseEntity
    {

       
        public async Task CreateAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
            _context.SaveChanges();

        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _context.Remove(entity);
             await _context.SaveChangesAsync();
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();              
            
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
           return await _context.Set<TEntity>().FindAsync(id);
           
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

        }
    }
}
