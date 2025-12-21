using AITech.DataAccess.Context;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.SocialRepositories
{
    public class SocialRepository : GenericRepository<Social>, ISocialRepository
    {
        public SocialRepository(AppDbContext context) : base(context)
        {
        }
    }
}
