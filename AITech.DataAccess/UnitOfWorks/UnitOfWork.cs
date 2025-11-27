using AITech.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.UnitOfWorks
{
    public class UnitOfWork(AppDbContext _context) : IUnitOfWork

    {
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
            
        }
    }
}
