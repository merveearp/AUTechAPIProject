using AITech.DTO.AboutDtos;
using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.AboutServices
{
    public interface IAboutService 
    {
        Task<ResultAboutDto?> TGetAsync();
        Task TUpdateAsync(UpdateAboutDto updateDto);
        Task TCreateAsync(CreateAboutDto createDto);
    }
}
