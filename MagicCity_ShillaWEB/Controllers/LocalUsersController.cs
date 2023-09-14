using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.VM;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([FromForm] RegisterationRequestDto param)
        {
            var response = await _authService.RegisterAsync<APIResponseModel>(param);
            if (response != null || response.IsSuccess)
            {
                return RedirectToAction("Login");
            }
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
        public async Task<IActionResult> Signin([FromForm]LoginRequestDto param)
        {
            var response = await _authService.LoginAsync<APIResponseModel>(param);
            if (response == null || !response.IsSuccess)
            {
                ModelState.AddModelError("CustomError",response.ErrorMessages.FirstOrDefault());
                return RedirectToAction("Login",param);
            }

            var model = JsonConvert.DeserializeObject<LoginResponseDto>(Convert.ToString(response.Result));
            HttpContext.Session.SetString(SD.SessionToken,model.Token);

            var identityItem = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identityItem.AddClaim(new Claim(ClaimTypes.Name, model.User.UserName));
            identityItem.AddClaim(new Claim(ClaimTypes.Role, model.User.Role));
            var principal = new ClaimsPrincipal(identityItem);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);

            return RedirectToAction("IndexShilla", nameof(ShillaController));
        }
        [HttpGet]
        public IActionResult Register() {
            RegisterationRequestDto dtoParam = new();
            return View(dtoParam);
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.SetString(SD.SessionToken,String.Empty);
            return RedirectToAction(nameof(Login));
        }
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
