﻿using MagicCity_ShillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Shilla> GetShillas()
        {
            return new List<Shilla>
            {
                new Shilla
                {
                    Id = 1,
                    Name = "Pool View"
                },
                new Shilla
                {
                    Id = 2,
                    Name = "Beach View"
                }
            };
        }
    }
}
