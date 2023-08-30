using AutoMapper;
using MagicCity_ShillaWEB.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaWEB.Controllers
{
    public class ShillaController : Controller
    {
        private readonly IShillaService _shillaService;
        private readonly IMapper _mapper;
        public ShillaController(IShillaService shillaService, IMapper mapper)
        {
            _shillaService = shillaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexShilla()
        {

            return View();
        }
    }
}
