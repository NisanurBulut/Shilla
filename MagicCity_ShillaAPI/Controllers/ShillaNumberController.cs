using AutoMapper;
using MagicCity_ShillaAPI.Models.Dto;
using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShillaNumberController : Controller
    {
        protected APIResponseModel _apiResponseModel;
        private readonly IMapper _mapper;
        private readonly IShillaNumberRepository _shillaNumberRepo;
        public ShillaNumberController(IMapper mapper, IShillaNumberRepository shillaNumberRepository)
        {
            _mapper = mapper;
            _shillaNumberRepo = shillaNumberRepository;
            this._apiResponseModel = new APIResponseModel();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponseModel>> GetShillaNumbers()
        {
            try
            {
                IEnumerable<ShillaNumber> entityList = await _shillaNumberRepo.GetAllAsync();
                _apiResponseModel.Result = _mapper.Map<ShillaNumberDto>(entityList);
                _apiResponseModel.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponseModel);
            }
            catch (Exception ex)
            {
                _apiResponseModel.IsSuccess = false;
                _apiResponseModel.StatusCode = HttpStatusCode.BadRequest;
                _apiResponseModel.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _apiResponseModel;
        }
    }
}
