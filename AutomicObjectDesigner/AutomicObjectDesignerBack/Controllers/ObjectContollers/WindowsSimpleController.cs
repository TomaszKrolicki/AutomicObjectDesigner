using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects.Temp;
using Microsoft.AspNetCore.Mvc;

namespace AutomicObjectDesignerBack.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WindowsSimpleController : Controller
{
    public AppDatabaseContext _Context { get; }


    public WindowsSimpleController(AppDatabaseContext context)
    {
        _Context = context;
    }


    //Get https://localhost:7017/api/WindowsSimple
    [HttpGet]
    public IActionResult GetWindowsSimple()
    {
        var windowsSimple = DataWindowsSimple.Current.WindowsSimple;
        //var windowsSimple = _Context.WindowsSimple.ToList();

        return Ok(windowsSimple);
    }


    [HttpGet("{id}")]
    public IActionResult GetOneWindowsSimple(int id)
    {
        var windowsSimple = DataWindowsSimple.Current.WindowsSimple.Find(h => h.Id == id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        return Ok(windowsSimple);
    }


    [HttpPost]
    public IActionResult CreateWindowsSimple([FromBody] WindowsSimple windowsSimple)
    {
        var maxId = DataWindowsSimple.Current.WindowsSimple.Max(c => c.Id);

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

        DataWindowsSimple.Current.WindowsSimple.Add(createWindowsSimple);

        return CreatedAtRoute("GetWindowsSimple", new { id = createWindowsSimple.Id }, createWindowsSimple);
    }


    [HttpPut]
    public IActionResult UpdateWindowsSimple([FromBody] WindowsSimple newWindowsSimple)
    {
        var windowsSimple = DataWindowsSimple.Current.WindowsSimple.Find(h => h.Id == newWindowsSimple.Id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        windowsSimple.ProcessName = newWindowsSimple.ProcessName;
        //++
        return Ok(DataWindowsSimple.Current.WindowsSimple);
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteOneWindowsSimple(int id)
    {
        var windowsSimple = DataWindowsSimple.Current.WindowsSimple.Find(h => h.Id == id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        DataWindowsSimple.Current.WindowsSimple.Remove(windowsSimple);
        return Ok(DataWindowsSimple.Current.WindowsSimple);
    }
}