using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers;

[ApiController]
public class WindowsSimpleController : Controller
{
    [HttpPost]
    [Route("/api/[controller]")]
    public string WindowsSimple()
    {
        return "";
    }
}