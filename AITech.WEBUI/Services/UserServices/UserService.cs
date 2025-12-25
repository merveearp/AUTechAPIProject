using AITech.WEBUI.DTOs.TokenDtos;
using AITech.WEBUI.DTOs.UserDtos;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(RegisterUserDto registerDto)
        {
            var jsonContent = JsonConvert.SerializeObject(registerDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response =  await _httpClient.PostAsync("users/register", content);

            if(!response.IsSuccessStatusCode)
            {
                var error =await response.Content.ReadAsStringAsync();
                throw new Exception(error);
            }
        }

        public async Task<LoginResponseDto> LoginAsync(LoginUserDto loginDto)
        {
            
            var jsonContent = JsonConvert.SerializeObject(loginDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            
            var response = await _httpClient.PostAsync("users/login", content);

           
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception(error);
            }

            
            var responseContent = await response.Content.ReadAsStringAsync();

            
            var loginResponse = JsonConvert.DeserializeObject<LoginResponseDto>(responseContent);

           
            return loginResponse!;
        }



    }
}
