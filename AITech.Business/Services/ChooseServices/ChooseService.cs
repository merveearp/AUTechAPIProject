using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.ChooseDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.ChooseServices
{
    public class ChooseService(IChooseRepository _chooseRepository,IUnitOfWork _unitOfWork) : IChooseService 
    {
        public async Task TCreateAsync(CreateChooseDto createDto)
        {
            var entity = createDto.Adapt<Choose>();
            await _chooseRepository.CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<ResultChooseDto?> TGetAsync()
        {
            var choose = await _chooseRepository.GetAsync();

            if (choose == null)
                return null;

            return choose.Adapt<ResultChooseDto>();
        }

        public async Task TUpdateAsync(UpdateChooseDto updateDto)
        {
            var entity = updateDto.Adapt<Choose>();
            _chooseRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
