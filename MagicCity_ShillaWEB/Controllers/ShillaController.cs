using AutoMapper;
using Azure;
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShilla(CreateShillaDto paramModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            var response = await _shillaService.CreateAsync<APIResponse>(paramModel);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexShilla));
            }
            return View(ModelState);
        }
        public async Task<IActionResult> CreateShilla()
        {
            return View(new CreateShillaDto());
        }
    }
}
