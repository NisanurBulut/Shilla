using MagicCity_ShillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaAPI.Controllers
{
    [Route("api/ShillaAPI")]
    [ApiController]
    public class ShillaAPIController : ControllerBase
    {
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
