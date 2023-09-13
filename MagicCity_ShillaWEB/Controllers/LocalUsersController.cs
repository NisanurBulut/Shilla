using Microsoft.AspNetCore.Mvc;

namespace MagicCity_ShillaWEB.Controllers
{
    public class LocalUsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
