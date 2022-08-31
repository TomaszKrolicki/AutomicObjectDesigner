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
        //var windowsSimple = DataWindowsSimple.Current.WindowsSimple;
        var windowsSimple = _Context.WindowsSimple.ToList();

        return Ok(windowsSimple);
    }


    [HttpGet("{id}")]
    public IActionResult GetOneWindowsSimple(int id)
    {
        var windowsSimple = _Context.WindowsSimple.Find(id);
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

        _Context.WindowsSimple.Add(createWindowsSimple);
        _Context.SaveChanges();

        return Ok(_Context.WindowsSimple.ToList());
    }


    [HttpPut]
    public IActionResult UpdateWindowsSimple([FromBody] WindowsSimple newWindowsSimple)
    {
        var DBwindowsSimple = _Context.WindowsSimple.Find(newWindowsSimple.Id);
        if (DBwindowsSimple == null)
            return BadRequest("WindowsSimple not found");
        DBwindowsSimple.ProcessName = newWindowsSimple.ProcessName;
        DBwindowsSimple.NameSuffix = newWindowsSimple.NameSuffix;
        DBwindowsSimple.ObjectName = newWindowsSimple.ObjectName;
        DBwindowsSimple.ProcessInfo = newWindowsSimple.ProcessInfo;
        DBwindowsSimple.Docu = newWindowsSimple.Docu;
        DBwindowsSimple.Title = newWindowsSimple.Title;
        DBwindowsSimple.Archive1 = newWindowsSimple.Archive1;
        DBwindowsSimple.Archive2 = newWindowsSimple.Archive2;
        DBwindowsSimple.InternalAccount = newWindowsSimple.InternalAccount;
        DBwindowsSimple.Floder = newWindowsSimple.Floder;
        _Context.SaveChanges();
        return Ok(_Context.WindowsSimple.ToList());
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteOneWindowsSimple(int id)
    {
        var DBwindowsSimple = _Context.WindowsSimple.Find(id);
        if (DBwindowsSimple == null)
            return BadRequest("WindowsSimple not found");
        _Context.WindowsSimple.Remove(DBwindowsSimple);
        _Context.SaveChanges();
        return Ok(_Context.WindowsSimple.ToList());
    }
}