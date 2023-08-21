﻿using MagicCity_ShillaAPI.Data;
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
        [HttpGet("{id:int}")]
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
    }
}
