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
        var windowsSimple = DataWindowsSimple.Current.WindowsSimpleData;

        return Ok(windowsSimple);
    }


    [HttpGet("{id}")]
    public IActionResult GetOneWindowsSimple(int id)
    {
        var windowsSimple = DataWindowsSimple.Current.WindowsSimpleData.Find(h => h.id == id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        return Ok(windowsSimple);
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


    [HttpPut]
    public IActionResult UpdateWindowsSimple([FromBody] WindowsSimple newWindowsSimple)
    {
        var windowsSimple = DataWindowsSimple.Current.WindowsSimpleData.Find(h => h.id == newWindowsSimple.id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        windowsSimple.ProcessName = newWindowsSimple.ProcessName;
        //++
        return Ok(DataWindowsSimple.Current.WindowsSimpleData);
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteOneWindowsSimple(int id)
    {
        var windowsSimple = DataWindowsSimple.Current.WindowsSimpleData.Find(h => h.id == id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        DataWindowsSimple.Current.WindowsSimpleData.Remove(windowsSimple);
        return Ok(DataWindowsSimple.Current.WindowsSimpleData);
    }
}