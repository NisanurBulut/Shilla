using AutoMapper;
using MagicShilla_Utility.Dto;
using MagicShilla_Utility.Entity;
using MagicCity_ShillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using MagicCity_ShillaWEB.Models;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShillaNumberController : Controller
    {
        protected APIResponse _apiResponseModel;
        private readonly IMapper _mapper;
        private readonly IShillaNumberRepository _shillaNumberRepo;
        private readonly IShillaRepository _shillaRepo;
        public ShillaNumberController(IMapper mapper, IShillaNumberRepository shillaNumberRepository, IShillaRepository shillaRepo)
        {
            _mapper = mapper;
            _shillaNumberRepo = shillaNumberRepository;
            this._apiResponseModel = new APIResponse();
            _shillaRepo = shillaRepo;
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetShillaNumbers()
        {
            try
            {
                IEnumerable<ShillaNumber> entityList = await _shillaNumberRepo.GetAllAsync(includeProperties:"Shilla");
                var response = new List<ShillaNumberDto>();
                foreach (var entity in entityList)
                {
                    response.Add(_mapper.Map<ShillaNumberDto>(entity));
                }
                _apiResponseModel.Result = response;
                _apiResponseModel.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponseModel);
            }
            catch (Exception ex)
            {
                _apiResponseModel.setBadRequestWithErrorMessage(ex.ToString());
            }
            return _apiResponseModel;
        }

        [HttpGet("{id:int}", Name = "GetShillaNumberById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetShillaNumber(int id)
        {
            try
            {
                if (id == 0)
                {
                    _apiResponseModel.setBadRequest();
                }
                var shillaNumberItem = await _shillaNumberRepo.GetAsync(u => u.ShillaNo == id, includeProperties:"Shilla");
                if (shillaNumberItem == null)
                {
                    _apiResponseModel.StatusCode = HttpStatusCode.NotFound;

                }
                _apiResponseModel.Result = _mapper.Map<ShillaNumberDto>(shillaNumberItem);
                _apiResponseModel.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponseModel);
            }
            catch (Exception ex)
            {
                _apiResponseModel.setBadRequestWithErrorMessage(ex.ToString());
            }
            return _apiResponseModel;
        }

        [HttpPost]
        public async Task<ActionResult<APIResponse>> CreateShillaNumber([FromBody] ShillaNumberCreateDto shillaNumberDto)
        {
            try
            {
                #region custom validation
                if (await _shillaNumberRepo.GetAsync(a => a.ShillaNo == shillaNumberDto.ShillaNo) != null)
                {
                    ModelState.AddModelError("Custom Error", "Shilla Number is already exists !");
                    _apiResponseModel.setBadRequestWithErrorMessage("Shilla Number is already exists !");
                    return BadRequest(ModelState);
                }

                if(await _shillaRepo.GetAsync(a => a.Id == shillaNumberDto.ShillaID) == null)
                {
                    ModelState.AddModelError("Custom Error", "Shilla ID is invalid !");
                    _apiResponseModel.setBadRequestWithErrorMessage("Shilla ID is invalid !");
                    return BadRequest(ModelState);
                }

                #endregion
                #region using ModelState.IsValid
                if (!ModelState.IsValid)
                {
                    _apiResponseModel.setBadRequest();
                    return BadRequest(ModelState);
                }
                #endregion
                if (shillaNumberDto == null)
                {
                    _apiResponseModel.setBadRequest();
                    return BadRequest(shillaNumberDto);
                }

                ShillaNumber entityItem = _mapper.Map<ShillaNumber>(shillaNumberDto);
                _apiResponseModel.Result = _shillaNumberRepo.CreateAsync(entityItem);
                return CreatedAtRoute("GetShillaNumberById", new { id = entityItem.ShillaNo }, shillaNumberDto);
            }
            catch (Exception ex)
            {
                _apiResponseModel.setBadRequestWithErrorMessage(ex.ToString());
            }
            return _apiResponseModel;
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteShillaNumberById")]
        public async Task<ActionResult<APIResponse>> DeleteShillaNumber(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var shillaNumberItem = await _shillaNumberRepo.GetAsync(u => u.ShillaNo == id);
                if (shillaNumberItem == null)
                {
                    return NotFound();
                }
                await _shillaNumberRepo.RemoveAsync(shillaNumberItem);
                _apiResponseModel.StatusCode = HttpStatusCode.OK;
                _apiResponseModel.IsSuccess = true;
                return Ok(_apiResponseModel);
            }
            catch (Exception ex)
            {
                _apiResponseModel.setBadRequestWithErrorMessage(ex.ToString());
            }
            return _apiResponseModel;
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}", Name = "UpdateShillaNumber")]
        public async Task<ActionResult<APIResponse>> UpdateShillaNumber(int id, [FromBody] ShillaNumberUpdateDto shillaNumberDto)
        {
            try
            {
                if (shillaNumberDto == null || id != shillaNumberDto.ShillaNo)
                {
                    _apiResponseModel.setBadRequest();
                    return BadRequest(shillaNumberDto);
                }
                if (await _shillaRepo.GetAsync(a => a.Id == shillaNumberDto.ShillaID) == null)
                {
                    ModelState.AddModelError("Custom Error", "Shilla ID is invalid !");
                    _apiResponseModel.setBadRequestWithErrorMessage("Shilla ID is invalid !");
                    return BadRequest(ModelState);
                }
                ShillaNumber entityItem = _mapper.Map<ShillaNumber>(shillaNumberDto);

                await _shillaNumberRepo.UpdateAsync(entityItem);
                _apiResponseModel.IsSuccess = true;
                _apiResponseModel.StatusCode = HttpStatusCode.NoContent;
                return Ok(_apiResponseModel);
            }
            catch (Exception ex)
            {
                _apiResponseModel.setBadRequestWithErrorMessage(ex.ToString());
            }
            return _apiResponseModel;
        }
    }
}
