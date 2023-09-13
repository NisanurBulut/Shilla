using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaWEB.Controllers
{
    public class LocalUsersController : Controller
    {
        private readonly IAuthService _authService;
        public LocalUsersController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginRequestDto param)
        {

            var response = await _authService.LoginAsync<APIResponse>(param);
            if (response != null || response.IsSuccess)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterationRequestDto param)
        {
            var response = await _authService.RegisterAsync<APIResponse>(param);
            if (response != null || response.IsSuccess)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            return View(null);
        }
    }
}
