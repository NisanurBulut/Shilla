using AutoMapper;
using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Logging;
using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Collections.Immutable;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ShillaDbContext _context;
        public ShillaAPIController(ShillaDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShillaDto>>> GetShillas()
        {
            IEnumerable<Shilla> entityList = await _context.Shillas.ToListAsync();
            return Ok(_mapper.Map<ShillaDto>(entityList));
        }
        [HttpGet("{id:int}", Name = "GetShillaById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ShillaDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ShillaDto>> GetShilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var shillaItem = await _context.Shillas.FirstOrDefaultAsync(u => u.Id == id);
            if (shillaItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ShillaDto>(shillaItem));
        }

        [HttpPost]
        public async Task<ActionResult<ShillaDto>> CreateShilla([FromBody] CreateShillaDto shillaDto)
        {
            #region custom validation
            if (await _context.Shillas.FirstOrDefaultAsync(a => a.Name.ToLower() == shillaDto.Name.ToLower()) != null)
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

            Shilla entityItem = _mapper.Map<Shilla>(shillaDto);
             await _context.Shillas.AddAsync(entityItem);
             await _context.SaveChangesAsync();
            return CreatedAtRoute("GetShillaById", new { id = entityItem.Id }, shillaDto);
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
            var shillaItem = _context.Shillas.FirstOrDefault(u => u.Id == id);
            if (shillaItem == null)
            {
                return NotFound();
            }
            _context.Shillas.Remove(shillaItem);
            _context.SaveChanges();
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}", Name = "UpdateShilla")]
        public async Task<IActionResult> UpdateShilla(int id, [FromBody] ShillaDto shillaDto)
        {
            if (shillaDto == null || id != shillaDto.Id)
            {
                return BadRequest(shillaDto);
            }

            Shilla entityItem = _mapper.Map<Shilla>(shillaDto);

            _context.Shillas.Update(entityItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id:int}", Name = "UpdatePartialShilla")]
        public async Task<IActionResult> UpdatePartialShilla(int id, JsonPatchDocument<UpdateShillaDto> pathcItem)
        {
            if (pathcItem == null || id == 0)
            {
                return BadRequest();
            }

            var shillaItem = await _context.Shillas.FirstOrDefaultAsync(a => a.Id == id);
            UpdateShillaDto shillaDtoItem= _mapper.Map<UpdateShillaDto>(shillaItem);
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
            _context.Update(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
