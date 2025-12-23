using AITech.WEBUI.DTOs.FeatureDtos;

namespace AITech.WEBUI.Services.FeatureServices
{
    public interface IFeatureService
    {
        Task<List<ResultFeatureDto>> GetAllAsync();
        Task<UpdateFeatureDto> GetByIdAsync(int id);
        Task CreateAsync(CreateFeatureDto featureDto);
        Task UpdateAsync(UpdateFeatureDto featureDto);
        Task DeleteAsync(int id);
    }
}
