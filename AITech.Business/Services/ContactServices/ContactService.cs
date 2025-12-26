using AITech.DataAccess.Repositories.ContactRespositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.DTO.ContactDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.ContactServices
{
    public class ContactService(IContactRepository _contactRepository,IUnitOfWork _unitOfWork) : IContactService
    {
        public async Task TCreateAsync(CreateContactDto contactDto)
        {
            var entity = contactDto.Adapt<Contact>();
            await _contactRepository.CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<ResultContactDto> TGetAsync()
        {
            var about = await _contactRepository.GetAsync();

            if (about == null)
                return null;

            return about.Adapt<ResultContactDto>();
        }

        public async Task TUpdateAsync(UpdateContactDto contactDto)
        {
            var entity = contactDto.Adapt<Contact>();
            _contactRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
