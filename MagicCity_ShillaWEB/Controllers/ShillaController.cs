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
        public async Task<IActionResult> UpdateShilla(int shillaId)
        {
            var shillaEntityResponse = await _shillaService.GetAsync<APIResponse>(shillaId);
            if (shillaEntityResponse!= null && shillaEntityResponse.IsSuccess==true)
            {
                ShillaDto shillaDtoModel = JsonConvert.DeserializeObject<ShillaDto>(Convert.ToString(shillaEntityResponse.Result));
                return View(_mapper.Map<UpdateShillaDto>(shillaDtoModel));
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateShilla(UpdateShillaDto paramModel)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelState);
            }
            var response = await _shillaService.UpdateAsync<APIResponse>(paramModel);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexShilla));
            }
            return View(ModelState);
        }
        public async Task<IActionResult> DeleteShilla(int shillaId)
        {
            var shillaEntityResponse = await _shillaService.GetAsync<APIResponse>(shillaId);
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
           
            var response = await _shillaService.DeleteAsync<APIResponse>(paramModel.Id);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexShilla));
            }
            return View(ModelState);
        }
    }
}
