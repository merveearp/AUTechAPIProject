using AITech.Business.Services.GenericServices;
using AITech.DTO.ChooseItemDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.ChooseItemServices
{
    public interface IChooseItemService : IGenericService<ResultChooseItemDto,CreateChooseItemDto,UpdateChooseItemDto>
    {
    }
}
