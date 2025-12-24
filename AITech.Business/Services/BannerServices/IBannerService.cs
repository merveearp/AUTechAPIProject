using AITech.Business.Services.GenericServices;
using AITech.DTO.BannerDtos;
using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.BannerServices
{
    public interface IBannerService 
    {
        Task<ResultBannerDto?> TGetAsync();
        Task TUpdateAsync(UpdateBannerDto updateDto);
        Task TCreateAsync(CreateBannerDto createDto);
    }
}
