using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.ContactRespositories
{
    public interface IContactRepository
    {
        Task<Contact?> GetAsync();
        Task CreateAsync(Contact contact);
        void Update(Contact contact);
    }
}
