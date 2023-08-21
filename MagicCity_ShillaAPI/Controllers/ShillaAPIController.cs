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
        public IEnumerable<ShillaDto> GetShillas()
        {
            return ShillaStore.shillaList;
        }
        [HttpGet("id")]
        public ShillaDto GetShilla(int id)
        {
            return ShillaStore.shillaList.FirstOrDefault(u => u.Id == id);
        }
    }
}
