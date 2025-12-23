using AITech.Business.Services.GenericServices;
using AITech.DTO.FeatureDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.FeatureServices
{
    public interface IFeatureService :IGenericService<ResultFeatureDto,CreateFeatureDto,UpdateFeatureDto>
    {
    }
}
