using AITech.Business.Services.GenericServices;
using AITech.DataAccess.Repositories.FAQRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.FAQDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.FAQServices
{
    public class FAQService(IFAQRepository _fAQRepository,IUnitOfWork _unitOfWork) : IFAQService
    {
        public async Task TCreateAsync(CreateFAQDto createFAQ)
        {
            var value = createFAQ.Adapt<FAQ>();
            await _fAQRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();   

        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _fAQRepository.GetByIdAsync(id);
            if(value is null)
            {
                throw new Exception("Seçenek bulunamadı");

            }
            _fAQRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultFAQDto>> TGetAllAsync()
        {
            var values = await _fAQRepository.GetAllAsync();
            return values.Adapt<List<ResultFAQDto>>();

        }

        public async Task<ResultFAQDto> TGetByIdAsync(int id)
        {
            var value = await _fAQRepository.GetByIdAsync(id);
            return value.Adapt<ResultFAQDto>();

        }

        public async Task TUpdateAsync(UpdateFAQDto updateFAQ)
        {
            var value = updateFAQ.Adapt<FAQ>();
            await _fAQRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
