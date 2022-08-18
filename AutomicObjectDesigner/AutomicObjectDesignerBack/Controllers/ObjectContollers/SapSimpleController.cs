using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    [ApiController]
    [Route(template:"api/")]
    public class SapSimpleController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return View();
            // pobranie danych uzytkownika + validacja
        }
    }
}
