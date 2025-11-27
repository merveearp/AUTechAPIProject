using AITech.Business.Services.GenericServices;
using AITech.DTO.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.CategoryServices
{
    public interface ICategoryService :IGenericService<ResultCategoryDto,CreateCategoryDto,UpdateCategoryDto>
    {
  
    }
}
