using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers;

[ApiController]
//[Route("api/WindowsSimple")]
[Route("api/[controller]")]
public class WindowsSimpleController : Controller
{
    //Get https://localhost:3000/api/WindowsSimple
    [HttpGet]
    public IActionResult GetWindowsSimple()
    {
        var WindowsSimple = DataWindowsSimple.Current.WindowsSimpleData;

        return Ok(WindowsSimple);
    }
    [HttpPost]
    public IActionResult CreateWindowsSimple([FromBody] WindowsSimple windowsSimple)
    {
        var maxId = DataWindowsSimple.Current.WindowsSimpleData.Max(c => c.Id);

        var createWindowsSimple = new WindowsSimple
        {
            Id = maxId + 1,
            ProcessName = "",
            NameSuffix = "",
            ObjectName = "",
            ProcessInfo = "",
            Docu = "",
            Title = "",
            Archive1 = "",
            Archive2 = "",
            InternalAccount = "",
            Floder = "",
        };

        DataWindowsSimple.Current.WindowsSimpleData.Add(createWindowsSimple);

        return CreatedAtRoute("GetWindowsSimple", new { id = createWindowsSimple.Id }, createWindowsSimple);
    }
}