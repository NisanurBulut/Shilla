﻿using MagicCity_ShillaAPI.Data;
using MagicCity_ShillaAPI.Logging;
using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Models.Dto;
using MagicCity_ShillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
        private readonly IShillaRepository _shillaRepo;
        public ShillaAPIController(IShillaRepository shillaRepo)
        {
           _shillaRepo=shillaRepo
        }


        [HttpGet]
        public ActionResult<IEnumerable<ShillaDto>> GetShillas()
        {
            return Ok(_shillaRepo.GetAll());
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
            var shillaItem = _context.Shillas.FirstOrDefault(u => u.Id == id);
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
            if (_context.Shillas.FirstOrDefault(a => a.Name.ToLower() == shillaDto.Name.ToLower()) != null)
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
            Shilla entityItem = new()
            {
                Name = shillaDto.Name,
                Occupancy = shillaDto.Occupancy,
                Sqft = shillaDto.Sqft,
                Details = shillaDto.Details,
                Rate = shillaDto.Rate,
                Amenity = shillaDto.Amenity,
                ImageUrl = shillaDto.ImageUrl,
                CreatedAt = DateTime.Now,
            };
            _context.Shillas.Add(entityItem);
            _context.SaveChanges();
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
        public IActionResult UpdateShilla(int id, [FromBody] ShillaDto shillaDto)
        {
            if (shillaDto == null || id != shillaDto.Id)
            {
                return BadRequest(shillaDto);
            }

            Shilla entityItem = new()
            {
                Id = id,
                Name = shillaDto.Name,
                Occupancy = shillaDto.Occupancy,
                Sqft = shillaDto.Sqft,
                Details = shillaDto.Details,
                Rate = shillaDto.Rate,
                Amenity = shillaDto.Amenity,
                ImageUrl = shillaDto.ImageUrl,
                CreatedAt = DateTime.Now,
            };

            _context.Shillas.Update(entityItem);
            _context.SaveChanges();
            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id:int}", Name = "UpdatePartialShilla")]
        public IActionResult UpdatePartialShilla(int id, JsonPatchDocument<ShillaDto> pathcItem)
        {
            if (pathcItem == null || id == 0)
            {
                return BadRequest();
            }

            var shillaItem = _context.Shillas.FirstOrDefault(a => a.Id == id);

            if (shillaItem == null)
            {
                return BadRequest();
            }
            ShillaDto shillaDtoItem = new()
            {
                Id = id,
                Name = shillaItem.Name,
                Occupancy = shillaItem.Occupancy,
                Sqft = shillaItem.Sqft,
                Details = shillaItem.Details,
                Rate = shillaItem.Rate,
                Amenity = shillaItem.Amenity,
                ImageUrl = shillaItem.ImageUrl,
                UpdatedAt = DateTime.Now
            };
            pathcItem.ApplyTo(shillaDtoItem);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            shillaItem.Name = shillaDtoItem.Name;
            shillaItem.Occupancy = shillaDtoItem.Occupancy;
            shillaItem.Sqft = shillaDtoItem.Sqft;
            shillaItem.Details = shillaDtoItem.Details;
            shillaItem.Rate = shillaDtoItem.Rate;
            shillaItem.Amenity = shillaDtoItem.Amenity;
            shillaItem.ImageUrl = shillaDtoItem.ImageUrl;
            shillaItem.UpdatedAt = DateTime.Now;

            _context.SaveChanges();

            return NoContent();
        }
    }
}
