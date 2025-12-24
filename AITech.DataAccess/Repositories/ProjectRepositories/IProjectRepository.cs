using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.ProjectRepositories
{
    public interface IProjectRepository:IRepository<Project> 
    {
        Task<List<Project>> GetProjectWithCategoriesAsync();
        Task MakeActiveAsync(Project project);
        Task MakePassiveAsync(Project project);
    }
}
