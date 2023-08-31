using AutoMapper;
using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicCity_ShillaWEB.Controllers
{
    public class ShillaController : Controller
    {
        private readonly IShillaService _shillaService;
        private readonly IMapper _mapper;
        public ShillaController(IShillaService shillaService, IMapper mapper)
        {
            _shillaService = shillaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexShilla()
        {
            List<ShillaDto> shillaDtos = new List<ShillaDto>();
            var response = await _shillaService.GetAllAsync<APIResponse>();
            if(response!=null  && response.IsSuccess)
            {
                shillaDtos = JsonConvert.DeserializeObject<List<ShillaDto>>(Convert.ToString(response.Result));
            }
            return View(shillaDtos);
        }
    }
}
