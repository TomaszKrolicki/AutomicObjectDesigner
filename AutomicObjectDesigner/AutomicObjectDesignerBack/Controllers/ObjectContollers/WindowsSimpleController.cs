using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects.Temp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<List<WindowsSimple>>> Get()
    {
        return Ok(await _Context.WindowsSimple.ToListAsync());
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<WindowsSimple>> GetOneWindowsSimple(int id)
    {
        var windowsSimple = await _Context.WindowsSimple.FindAsync(id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        return Ok(windowsSimple);
    }


    [HttpPost]
    public async Task<ActionResult<List<WindowsSimple>>> CreateWindowsSimple(WindowsSimple windowsSimple)
    {
        //var maxId = DataWindowsSimple.Current.WindowsSimple.Max(c => c.Id);

        //var createWindowsSimple = new WindowsSimple
        //{
        //    Id = maxId + 1,
        //    ProcessName = "",
        //    NameSuffix = "",
        //    ObjectName = "",
        //    ProcessInfo = "",
        //    Docu = "",
        //    Title = "",
        //    Archive1 = "",
        //    Archive2 = "",
        //    InternalAccount = "",
        //    Floder = "",
        //};

        _Context.WindowsSimple.Add(windowsSimple);
        await _Context.SaveChangesAsync();

        return Ok(await _Context.WindowsSimple.ToListAsync());
    }


    [HttpPut]
    public async Task<ActionResult<List<WindowsSimple>>> UpdateWindowsSimple(WindowsSimple newWindowsSimple)
    {
        var DBwindowsSimple = await _Context.WindowsSimple.FindAsync(newWindowsSimple.Id);
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
        await _Context.SaveChangesAsync();
        return Ok(await _Context.WindowsSimple.ToListAsync());
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult<List<WindowsSimple>>> DeleteOneWindowsSimple(int id)
    {
        var DBwindowsSimple = await _Context.WindowsSimple.FindAsync(id);
        if (DBwindowsSimple == null)
            return BadRequest("WindowsSimple not found");
        _Context.WindowsSimple.Remove(DBwindowsSimple);
        await _Context.SaveChangesAsync();
        return Ok(await _Context.WindowsSimple.ToListAsync());
    }
}