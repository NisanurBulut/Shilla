using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Logging;
using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
        private readonly ILogging _logger;

        public ShillaAPIController(ILogging logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ShillaDto>> GetShillas()
        {
            _logger.Log("Getting all Shilla items","");
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
                _logger.Log($"Get Shilla error with id {id}","error");
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

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteShillaById")]
        public IActionResult DeleteShilla(int id)
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
            ShillaStore.shillaList.Remove(shillaItem);
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}", Name = "UpdateShilla")]
        public IActionResult UpdateShilla(int id, [FromBody] ShillaDto shillaDto)
        {
            if (shillaDto == null || id != shillaDto.Id)
            {
                return BadRequest(shillaDto);
            }

            var shillaItem = ShillaStore.shillaList.FirstOrDefault(a => a.Id == id);
            shillaItem.Name = shillaDto.Name;
            shillaItem.Sqft = shillaDto.Sqft;
            shillaItem.Occupancy = shillaDto.Occupancy;
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id:int}", Name ="UpdatePartialShilla")]
        public IActionResult UpdatePartialShilla(int id, JsonPatchDocument<ShillaDto> pathcItem)
        {
            if(pathcItem == null || id == 0)
            {
                return BadRequest();
            }

            var shillaItem = ShillaStore.shillaList.FirstOrDefault(a => a.Id == id);
            pathcItem.ApplyTo(shillaItem);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
