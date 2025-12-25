using AITech.DTO.TokenDtos;
using AITech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.TokenServices
{
    public interface ITokenService
    {
        LoginResponseDto CreateToken(AppUser user);
    }
}
