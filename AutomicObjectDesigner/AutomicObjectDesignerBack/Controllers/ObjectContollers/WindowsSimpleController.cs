using AutomicObjectDesigner.Models.Objects;
using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers;

[ApiController]
public class WindowsSimpleController : Controller
{
    [Route("/api/WindowsSimple")]
    [HttpPost]
    public IActionResult GetWindowsSimple(WindowsSimple windowsSimple)
    {
        windowsSimple.id = 1;
        windowsSimple.ProcessName = "Process";
        windowsSimple.NameSuffix = "Suffix";
        windowsSimple.ObjectName = "sid1.client1#ZZZ#Process#WIN_Suffix.JOBS"
        if (windowsSimple.ObjectName == "sid1.client1#ZZZ#Process#WIN_Suffix.JOBS")
        {
            windowsSimple.Process = "";
            windowsSimple.Docu = "";
            windowsSimple.Title = "";
            windowsSimple.Archive1 = "";
            windowsSimple.Archive2 = "";
            windowsSimple.InternalAccount = "account";
            // SaveInDatabase(WindowsSimple)
        }
        return Ok(windowsSimple);
        //Go to next website
    }
}