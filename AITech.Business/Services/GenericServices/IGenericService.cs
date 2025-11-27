using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.GenericServices
{
    public interface IGenericService<TResultDto,TCreateDto,TUpdateDto>
    {
        Task<IList<TResultDto>> TGetAllAsync();
        Task<TResultDto> TGetByIdAsync(int id);
        Task TCreateAsync(TCreateDto entity);
        Task TUpdateAsync(TUpdateDto entity);
        Task TDeleteAsync(int id);
    }
}
