using MagicCity_ShillaAPI.Models;
using MagicCity_ShillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ShillaDto> GetShillas()
        {
            return new List<ShillaDto>
            {
                new ShillaDto
                {
                    Id = 1,
                    Name = "Pool View"
                },
                new ShillaDto
                {
                    Id = 2,
                    Name = "Beach View"
                }
            };
        }
    }
}
