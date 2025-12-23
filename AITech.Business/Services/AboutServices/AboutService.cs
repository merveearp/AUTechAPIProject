using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.AboutServices
{
    public class AboutService(IAboutRepository _aboutRepository, IUnitOfWork _unitOfWork) : IAboutService
    {
        public async Task TCreateAsync(CreateAboutDto createDto)
        {
            var entity = createDto.Adapt<About>();
            await _aboutRepository.CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<ResultAboutDto?> TGetAsync()
        {
            var about = await _aboutRepository.GetAsync();

            if (about == null)
                return null;

            return about.Adapt<ResultAboutDto>();
        }

        public async Task TUpdateAsync(UpdateAboutDto updateDto)
        {
            var entity = updateDto.Adapt<About>();
            _aboutRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
