using AITech.DataAccess.Repositories.ChooseItemRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.ChooseItemDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.ChooseItemServices
{
    public class ChooseItemService(IChooseItemRepository _itemRepository ,IUnitOfWork _unitOfWork) : IChooseItemService
    {
        public async Task TCreateAsync(CreateChooseItemDto createDto)
        {
            var entity = createDto.Adapt<ChooseItem>();
            await _itemRepository.CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var entity = await _itemRepository.GetByIdAsync(id);

            _itemRepository.Delete(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultChooseItemDto>> TGetAllAsync()
        {
            var entities = await _itemRepository.GetAllAsync();
            return entities.Adapt<List<ResultChooseItemDto>>();

        }

        public async Task<ResultChooseItemDto> TGetByIdAsync(int id)
        {
            var entity = await _itemRepository.GetByIdAsync(id);
            return entity.Adapt<ResultChooseItemDto>();
        }

        public async Task TUpdateAsync(UpdateChooseItemDto updateDto)
        {
            var entity = updateDto.Adapt<ChooseItem>();
            _itemRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
