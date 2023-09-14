using AutoMapper;
using Azure;
using MagicCity_ShillaWEB.Models;
using MagicCity_ShillaWEB.Services.IServices;
using MagicShilla_Utility;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.VM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicCity_ShillaWEB.Controllers
{
   
    public class ShillaController : Controller
    {
        private readonly IShillaService _shillaService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _token;
        public ShillaController(IShillaService shillaService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _shillaService = shillaService;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _token = _httpContextAccessor.HttpContext.Session.GetString(SD.SessionToken);
        }
        public async Task<IActionResult> IndexShilla()
        {
            List<ShillaDto> shillaDtos = new List<ShillaDto>();
            var response = await _shillaService.GetAllAsync<APIResponseModel>(_token);
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
            var response = await _shillaService.CreateAsync<APIResponseModel>(paramModel, _token);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexShilla));
            }
            return View(ModelState);
        }
        [Authorize("admin")]
        public async Task<IActionResult> CreateShilla()
        {
            return View(new CreateShillaDto());
        }
        public async Task<IActionResult> UpdateShilla(int shillaId)
        {
            var shillaEntityResponse = await _shillaService.GetAsync<APIResponseModel>(shillaId, _token);
            if (shillaEntityResponse!= null && shillaEntityResponse.IsSuccess==true)
            {
                ShillaDto shillaDtoModel = JsonConvert.DeserializeObject<ShillaDto>(Convert.ToString(shillaEntityResponse.Result));
                return View(_mapper.Map<UpdateShillaDto>(shillaDtoModel));
            }
            return NotFound();
        }
        [Authorize("admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateShilla(UpdateShillaDto paramModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            var response = await _shillaService.UpdateAsync<APIResponseModel>(paramModel, _token);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexShilla));
            }
            return View(ModelState);
        }
        [Authorize("admin")]
        public async Task<IActionResult> DeleteShilla(int shillaId)
        {
            var shillaEntityResponse = await _shillaService.GetAsync<APIResponseModel>(shillaId, _token);
            if (shillaEntityResponse != null && shillaEntityResponse.IsSuccess == true)
            {
                ShillaDto shillaDtoModel = JsonConvert.DeserializeObject<ShillaDto>(Convert.ToString(shillaEntityResponse.Result));
                return View(_mapper.Map<UpdateShillaDto>(shillaDtoModel));
            }
            return NotFound();
        }
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteShilla(ShillaDto paramModel)
        {
           
            var response = await _shillaService.DeleteAsync<APIResponseModel>(paramModel.Id, _token);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexShilla));
            }
            return View(ModelState);
        }
    }
}
