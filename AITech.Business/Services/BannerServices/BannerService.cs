using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.UnitOfWorks;
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
            var banner = createDto.Adapt<Banner>();
            await _bannerRepository.CreateAsync(banner);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task TDeleteAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            _bannerRepository.Delete(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultBannerDto>> TGetAllAsync()
        {
            var banners = await _bannerRepository.GetAllAsync();
            return banners.Adapt<List<ResultBannerDto>>();
        }

        public async Task<ResultBannerDto> TGetByIdAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            return banner.Adapt<ResultBannerDto>();

        }

        public async Task TMakeActiveAsync(int id)
        {
            var banner =await _bannerRepository.GetByIdAsync(id);
            await _bannerRepository.MakeActiveAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TMakePassiveAsync(int id)
        {
            var banner = await _bannerRepository.GetByIdAsync(id);
            await _bannerRepository.MakeActiveAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TUpdateAsync(UpdateBannerDto updateDto)
        {
            var banner = updateDto.Adapt<Banner>();
            _bannerRepository.Update(banner);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
