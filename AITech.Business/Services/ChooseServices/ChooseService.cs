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

        public async Task TCreateAsync(CreateChooseDto createChoose)
        {
            var value = createChoose.Adapt<Choose>();
            await _chooseRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _chooseRepository.GetByIdAsync(id);
            if(value == null)
            {
                throw new Exception("Seçenek Bulunamadı");

            }
            _chooseRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task<IList<ResultChooseDto>> TGetAllAsync()
        {
            var values = await _chooseRepository.GetAllAsync();
            return values.Adapt<List<ResultChooseDto>>();
        }

        public async Task<ResultChooseDto> TGetByIdAsync(int id)
        {
            var value = await _chooseRepository.GetByIdAsync(id);
            return value.Adapt<ResultChooseDto>();

        }

        public async Task TUpdateAsync(UpdateChooseDto updateChoose)
        {
            var value = updateChoose.Adapt<Choose>();
             _chooseRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();

        }
    }
}
