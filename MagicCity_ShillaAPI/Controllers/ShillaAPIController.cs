using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ShillaDto>> GetShillas()
        {
            return Ok(ShillaStore.shillaList);
        }
        [HttpGet("{id:int}", Name = "GetShillaById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ShillaDto> GetShilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var shillaItem = ShillaStore.shillaList.FirstOrDefault(u => u.Id == id);
            if (shillaItem == null)
            {
                return NotFound();
            }
            return Ok(shillaItem);
        }

        [HttpPost]
        public ActionResult<ShillaDto> CreateShilla([FromBody] ShillaDto shillaDto)
        {
            #region custom validation
            if (ShillaStore.shillaList.FirstOrDefault(a => a.Name.ToLower() == shillaDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("", "Shilla city is already exists !");
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
            if (shillaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            shillaDto.Id = ShillaStore.shillaList.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            ShillaStore.shillaList.Add(shillaDto);
            return CreatedAtRoute("GetShillaById", new { id = shillaDto.Id }, shillaDto);
        }
    }
}
