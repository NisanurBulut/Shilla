﻿using AutoMapper;
using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Logging;
using MagicShilla_Utility.Entity;
using MagicShilla_Utility.Dto;
using MagicCity_ShillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Collections.Immutable;
using System.Net;
using MagicShilla_Utility.VM;
using Newtonsoft.Json.Serialization;
using System.Text.Json;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
        protected APIResponseModel _apiResponseModel;
        private readonly IMapper _mapper;
        private readonly IShillaRepository _shillaRepo;
        public ShillaAPIController(IShillaRepository shillaRepo, IMapper mapper)
        {
            _mapper = mapper;
            _shillaRepo = shillaRepo;
            this._apiResponseModel = new APIResponseModel();
        }


        [HttpGet]
        [ResponseCache(CacheProfileName = "Default30")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponseModel>> GetShillas([FromQuery(Name = "filterOccupancy")] int? paramOccupancy,
            [FromQuery(Name ="filterName")] string searchParam, int PageSize = 0, int PageNumber = 1)
        {
            IEnumerable<Shilla> entityList;
            if (paramOccupancy > 0)
            {
                entityList = await _shillaRepo.GetAllAsync(a => a.Occupancy == paramOccupancy, PageSize: PageSize,PageNumber:PageNumber);
            }
            else
            {
                entityList = await _shillaRepo.GetAllAsync(PageSize: PageSize, PageNumber: PageNumber);
            }
            if (!string.IsNullOrEmpty(searchParam))
            {
                entityList = await _shillaRepo.GetAllAsync(a=>a.Name.ToLower().Contains(searchParam), PageSize: PageSize, PageNumber: PageNumber);
            }
            var response = new List<ShillaDto>();
            foreach (var entity in entityList)
            {
                response.Add(_mapper.Map<ShillaDto>(entity));
            }
            Pagination pagination = new Pagination
            {
                PageSize = PageSize,
                PageNumber = PageNumber,
            };
            Response.Headers.Add("X-Pagination",JsonSerializer.Serialize(pagination));
            _apiResponseModel.Result = response;
            _apiResponseModel.IsSuccess = true;
            _apiResponseModel.StatusCode = HttpStatusCode.OK;
            return Ok(_apiResponseModel);

        }
        [HttpGet("{id:int}", Name = "GetShillaById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<ActionResult<ShillaDto>> GetShilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var shillaItem = await _shillaRepo.GetAsync(u => u.Id == id);
            if (shillaItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ShillaDto>(shillaItem));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<ShillaDto>> CreateShilla([FromBody] CreateShillaDto shillaDto)
        {
            #region custom validation
            if (await _shillaRepo.GetAsync(a => a.Name.ToLower() == shillaDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("ErrorMessages", "Shilla city is already exists !");
                return BadRequest(ModelState);
            }
            #endregion
            #region using ModelState.IsValid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            #endregion
            if (shillaDto == null)
            {
                return BadRequest(shillaDto);
            }

            Shilla entityItem = _mapper.Map<Shilla>(shillaDto);
            await _shillaRepo.CreateAsync(entityItem);
            return CreatedAtRoute("GetShillaById", new { id = entityItem.Id }, shillaDto);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteShillaById")]
        public async Task<IActionResult> DeleteShilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var shillaItem = await _shillaRepo.GetAsync(u => u.Id == id);
            if (shillaItem == null)
            {
                return NotFound();
            }
            await _shillaRepo.RemoveAsync(shillaItem);
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}", Name = "UpdateShilla")]
        public async Task<IActionResult> UpdateShilla(int id, [FromBody] UpdateShillaDto shillaDto)
        {
            if (shillaDto == null || id != shillaDto.Id)
            {
                return BadRequest(shillaDto);
            }

            Shilla entityItem = _mapper.Map<Shilla>(shillaDto);

            await _shillaRepo.UpdateAsync(entityItem);
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id:int}", Name = "UpdatePartialShilla")]
        public async Task<IActionResult> UpdatePartialShilla(int id, JsonPatchDocument<UpdateShillaDto> pathcItem)
        {
            if (pathcItem == null || id == 0)
            {
                return BadRequest();
            }

            var shillaItem = await _shillaRepo.GetAsync(a => a.Id == id, tracked: false);
            UpdateShillaDto shillaDtoItem = _mapper.Map<UpdateShillaDto>(shillaItem);
            if (shillaItem == null)
            {
                return BadRequest();
            }

            pathcItem.ApplyTo(shillaDtoItem, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var model = _mapper.Map<Shilla>(shillaDtoItem);
            await _shillaRepo.UpdateAsync(model);

            return NoContent();
        }
    }
}
