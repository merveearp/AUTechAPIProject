using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.ProjectRepositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext _context) : base(_context)
        {
        }

        public async Task<List<Project>> GetProjectWithCategoriesAsync()
        {
            return await _context.Projects.AsNoTracking().Include(x =>x.Category).ToListAsync();
        }

        public async Task MakeActiveAsync(Project project)
        {
            project.IsActive=true;
        }

        public async Task MakePassiveAsync(Project project)
        {
            project.IsActive = false;
        }
    }
}
