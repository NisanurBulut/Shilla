using AutoMapper;
using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicCity_ShillaWEB.Controllers
{
    public class ShillaNumberController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShillaNumberService _shillaNumberService;
        public ShillaNumberController(IMapper mapper, IShillaNumberService shillaNumberService)
        {
            this._mapper = mapper;
            this._shillaNumberService = shillaNumberService;
        }
        public async Task<IActionResult> IndexShillaNumberAsync()
        {
            List<ShillaNumberDto> shillaNumberDtos = new List<ShillaNumberDto>();
            var response = await _shillaNumberService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                shillaNumberDtos = JsonConvert.DeserializeObject<List<ShillaNumberDto>>(Convert.ToString(response.Result));
            }
            return View(shillaNumberDtos);
        }
    }
}
