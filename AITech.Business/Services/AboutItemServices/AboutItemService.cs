using AITech.Business.Services.GenericServices;
using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.AboutItemDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.AboutItemServices
{
    public class AboutItemService(IAboutItemRepository _aboutItemRepository, IUnitOfWork _unitOfWork) : IAboutItemService
    {
        public async Task TCreateAsync(CreateAboutItemDto createDto)
        {
            var item = createDto.Adapt<AboutItem>();
            await _aboutItemRepository.CreateAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var item = await _aboutItemRepository.GetByIdAsync(id);
            if (item is null)
            {
                throw new Exception(" Item bulunamadı!");
            }
            _aboutItemRepository.Delete(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultAboutItemDto>> TGetAllAsync()
        {
           var items = await _aboutItemRepository.GetAllAsync();
           return items.Adapt<IList<ResultAboutItemDto>>();
        }

        public async Task<ResultAboutItemDto> TGetByIdAsync(int id)
        {
            var item = await _aboutItemRepository.GetByIdAsync(id);
            return item.Adapt<ResultAboutItemDto>();
        }

        public async Task TUpdateAsync(UpdateAboutItemDto updateDto)
        {
            var item = updateDto.Adapt<AboutItem>();
            _aboutItemRepository.Update(item);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
