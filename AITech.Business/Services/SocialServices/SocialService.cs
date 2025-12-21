using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.SocialDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.SocialServices
{
    public class SocialService(ISocialRepository _socialRepository,IUnitOfWork _unitOfWork) : ISocialService
    {
        public async Task TCreateAsync(CreateSocialDto createSocial)
        {
            var value = createSocial.Adapt<Social>();
            await _socialRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();   
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _socialRepository.GetByIdAsync(id);
            if(value == null)
            {
                throw new Exception("Medya Bulunamadı");
            }
            _socialRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultSocialDto>> TGetAllAsync()
        {
            var values = await _socialRepository.GetAllAsync();
            return values.Adapt<IList<ResultSocialDto>>();
        }

        public async Task<ResultSocialDto> TGetByIdAsync(int id)
        {
            var value = await _socialRepository.GetByIdAsync(id);
            return value.Adapt<ResultSocialDto>();

        }

        public async Task TUpdateAsync(UpdateSocialDto updateSocial)
        {
            var value = updateSocial.Adapt<Social>();
            _socialRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
