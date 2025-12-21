using AITech.Business.Services.GenericServices;
using AITech.DTO.FAQDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.FAQServices
{
    public interface IFAQService :IGenericService<ResultFAQDto,CreateFAQDto,UpdateFAQDto>
    {
    }
}
