using AITech.DTO.UserDtos;
using AITech.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
       
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }

        public async Task CreateAsync(RegisterUserDto registerDto)
        {
            var emailExist = await _userManager.FindByEmailAsync(registerDto.Email);
            if(emailExist != null)
            {
                throw new Exception("Bu Email Adresi  Kaydı daha önceden bulunmaktadır");

            }
            var userExist = await _userManager.FindByNameAsync(registerDto.UserName);
            if(userExist != null)
            {
                throw new Exception("Bu Kullanıcı Adı Kullanılmaktadır");

            }
            var user = new AppUser
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                UserName = registerDto.UserName,
                Email = registerDto.Email
               
            };

            var result = await _userManager.CreateAsync(user,registerDto.Password);
  

             
            
        }

        public async Task LoginAsync(LoginUserDto userDto)
        {
            var user = await _userManager.FindByNameAsync(userDto.UserName);
            if (user == null)
            {
                throw new Exception("Kullanıcı Bulunamadı!");
         
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, userDto.Password,false);
            if (!result.Succeeded)
            {
                throw new Exception("Email veya şifre hatalı");
            }

        }
    }
}
