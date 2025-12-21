using AITech.Business.Services.GenericServices;
using AITech.DTO.SocialDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.SocialServices
{
    public interface ISocialService :IGenericService<ResultSocialDto,CreateSocialDto,UpdateSocialDto>
    {
    }
}
