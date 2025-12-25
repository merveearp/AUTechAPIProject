using AITech.DTO.UserDtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.UserServices
{
    public interface IUserService
    {
        Task CreateAsync(RegisterUserDto registerDto);
        Task LoginAsync(LoginUserDto userDto);
    }
}
