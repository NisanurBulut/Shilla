using AutoMapper;
using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace MagicCity_ShillaWEB.Controllers
{
    public class ShillaNumberController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IShillaNumberService _shillaNumberService;
        private readonly IShillaService _shillaService;
        public ShillaNumberController(IMapper mapper, IShillaNumberService shillaNumberService, IShillaService shillaService)
        {
            this._mapper = mapper;
            this._shillaNumberService = shillaNumberService;
            _shillaService = shillaService;
        }
        public async Task<IActionResult> IndexShillaNumber()
        {
            List<ShillaNumberDto> shillaNumberDtos = new List<ShillaNumberDto>();
            var response = await _shillaNumberService.GetAllAsync<APIResponseModel>();
            if (response != null && response.IsSuccess)
            {
                shillaNumberDtos = JsonConvert.DeserializeObject<List<ShillaNumberDto>>(Convert.ToString(response.Result));
            }
            return View(shillaNumberDtos);
        }
        public async Task<IActionResult> CreateShillaNumber()
        {
            ShillaNumberCreateVM shillaNumberCreateVM = new ShillaNumberCreateVM();
            var response = await _shillaService.GetAllAsync<APIResponseModel>();
            if (response != null && response.IsSuccess)
            {
                shillaNumberCreateVM.ShillaList = JsonConvert.DeserializeObject<List<ShillaDto>>(Convert.ToString(response.Result)).
                    Select(a => new SelectListItem
                    {
                        Text = a.Name,
                        Value = a.Id.ToString(),
                    });
            }
            return View(shillaNumberCreateVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateShillaNumber(ShillaNumberCreateVM shillaNumberCreateVM){

            if (!ModelState.IsValid)
            {
               
                return BadRequest(shillaNumberCreateVM);

            }
            var response =await _shillaNumberService.CreateAsync<APIResponseModel>(shillaNumberCreateVM.ShillaNumberCreateDto);

            if(response!=null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexShillaNumber));
            }

            return View(shillaNumberCreateVM);
        }
    }
}
