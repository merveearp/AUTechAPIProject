using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.FeatureDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.FeatureServices
{
    public class FeatureService(IFeatureRepository _featureRepository,IUnitOfWork _unitOfWork) : IFeatureService
    {
        public async Task TCreateAsync(CreateFeatureDto createFeature)
        {
            var entity = createFeature.Adapt<Feature>();
            await _featureRepository.CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var entity = await _featureRepository.GetByIdAsync(id);
            _featureRepository.Delete(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultFeatureDto>> TGetAllAsync()
        {
            var entities = await _featureRepository.GetAllAsync();
            return entities.Adapt<List<ResultFeatureDto>>();

        }

        public async Task<ResultFeatureDto> TGetByIdAsync(int id)
        {
            var entity = await _featureRepository.GetByIdAsync(id);
            if (entity is null)
            {
                throw new Exception(" Hizmet bulunamadı!");
            }
            return entity.Adapt<ResultFeatureDto>();
        }

        public async Task TUpdateAsync(UpdateFeatureDto updateFeature)
        {
            var entity = updateFeature.Adapt<Feature>();
             _featureRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
