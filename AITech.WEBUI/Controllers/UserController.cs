using AITech.WEBUI.DTOs.UserDtos;
using AITech.WEBUI.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WEBUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDto registerDto)
        {
            if (!ModelState.IsValid)
                return View(registerDto);

            try
            {
                await _userService.CreateAsync(registerDto);
                return RedirectToAction("Login", "User");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(registerDto);
            }
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserDto loginDto)
        {
            if (!ModelState.IsValid)
                return View(loginDto);

            try
            {
                var loginResponse = await _userService.LoginAsync(loginDto);

                HttpContext.Session.SetString("JWToken", loginResponse.Token);
                HttpContext.Session.SetString(
                    "TokenExpire",
                    loginResponse.ExpireDate.ToString("O")
                );
                return RedirectToAction("Index", "Home", new { area = "Admin" });

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(loginDto);
            }
        }
    }
}
