using AITech.Business.Services.GenericServices;
using AITech.DTO.AboutItemDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.AboutItemServices
{
    public interface IAboutItemService :IGenericService<ResultAboutItemDto,CreateAboutItemDto,UpdateAboutItemDto>
    {
    }
}
