using AITech.DataAccess.Context;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.ContactRespositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _context;

        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
        }

        public async Task<Contact?> GetAsync()
        {
            return await _context.Contacts.FirstOrDefaultAsync();
        }

        public void Update(Contact contact)
        {
            _context.Update(contact);
        }

    }
}
