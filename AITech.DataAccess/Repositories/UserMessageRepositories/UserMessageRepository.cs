using AITech.DataAccess.Context;
using AITech.DataAccess.Migrations;
using AITech.DataAccess.Repositories.GenericRepositories;
using AITech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DataAccess.Repositories.UserMessageRepositories
{
    public class UserMessageRepository : IUserMessageRepository
    {
        private readonly AppDbContext _context;

        public UserMessageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(UserMessage userMessage)
        {
            userMessage.CreatedDate = DateTime.Now;
            userMessage.IsCalled = false;

            await _context.UserMessages.AddAsync(userMessage);
        }

        public void Delete(UserMessage userMessage)
        {
            _context.Remove(userMessage);
        }

        public async Task<IList<UserMessage>> GetAllAsync()
        {
            return await _context.UserMessages.ToListAsync();
        }

        public async Task<UserMessage> GetByIdAsync(int id)
        {
           return await _context.UserMessages.FindAsync(id);
        }

        public void UpdateIsCalled(UserMessage userMessage)
        {
            if (userMessage.IsCalled)
                return;

            userMessage.IsCalled = true;
            userMessage.UpdatedDate = DateTime.Now;
        }


    }
}
