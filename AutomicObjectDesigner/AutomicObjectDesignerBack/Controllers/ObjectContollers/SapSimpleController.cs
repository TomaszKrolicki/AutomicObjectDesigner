using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    public class SapSimpleController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // pobranie danych uzytkownika + validacja
        }
    }
}
