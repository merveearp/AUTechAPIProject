using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutDtos;
using AITech.DTO.BannerDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.BannerServices
{
    public class BannerService(IBannerRepository _bannerRepository,
         IUnitOfWork _unitOfWork) : IBannerService
    {
        public async Task TCreateAsync(CreateBannerDto createDto)
        {
            var entity = createDto.Adapt<Banner>();
            await _bannerRepository.CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<ResultBannerDto?> TGetAsync()
        {
            var banner = await _bannerRepository.GetAsync();

            if (banner == null)
                return null;

            return banner.Adapt<ResultBannerDto>();
        }

        public async Task TUpdateAsync(UpdateBannerDto updateDto)
        {
            var entity = updateDto.Adapt<Banner>();
            _bannerRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
