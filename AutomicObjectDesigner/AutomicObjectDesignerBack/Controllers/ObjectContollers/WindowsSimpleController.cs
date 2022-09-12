using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects.Dto;
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
    public async Task<ActionResult<List<WindowsSimpleDto>>> Get()
    {
        return Ok(await _Context.WindowsSimple.ToListAsync());
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<WindowsSimpleDto>> GetOneWindowsSimple(int id)
    {
        var windowsSimple = await _Context.WindowsSimple.FindAsync(id);
        if (windowsSimple == null)
            return BadRequest("WindowsSimple not found");
        return Ok(windowsSimple);
    }


    [HttpPost]
    public async Task<ActionResult<List<WindowsSimpleDto>>> CreateWindowsSimple(WindowsSimpleDto WindowsSimple)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var windowsSimple = new WindowsSimple
        {
            WinServer = WindowsSimple.WinServer,
            WinLogin = WindowsSimple.WinLogin,
            SapSid = WindowsSimple.SapSid,
            SapClient = WindowsSimple.SapClient,
            RoutineJob = WindowsSimple.RoutineJob,
            ProcessName = WindowsSimple.ProcessName,
            NameSuffix = WindowsSimple.NameSuffix,
            DeleteSapJob = WindowsSimple.DeleteSapJob
        };

        _Context.WindowsSimple.Add(windowsSimple);
        await _Context.SaveChangesAsync();

        return Ok(await _Context.WindowsSimple.ToListAsync());
    }


    [HttpPut]
    public async Task<ActionResult<List<WindowsSimpleDto>>> UpdateWindowsSimple(WindowsSimple updateWindowsSimple)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var windowsSimple = await _Context.WindowsSimple.FindAsync(updateWindowsSimple.Id);

        if (windowsSimple == null)
        {
            return NotFound();
        }

        windowsSimple.WinServer = updateWindowsSimple.WinServer;
        windowsSimple.WinLogin = updateWindowsSimple.WinLogin;
        windowsSimple.SapSid = updateWindowsSimple.SapSid;
        windowsSimple.SapClient = updateWindowsSimple.SapClient;
        windowsSimple.RoutineJob = updateWindowsSimple.RoutineJob;
        windowsSimple.ProcessName = updateWindowsSimple.ProcessName;
        windowsSimple.NameSuffix = updateWindowsSimple.NameSuffix;
        windowsSimple.DeleteSapJob = updateWindowsSimple.DeleteSapJob;

        await _Context.SaveChangesAsync();
        return Ok(await _Context.WindowsSimple.ToListAsync());
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult<List<WindowsSimpleDto>>> DeleteOneWindowsSimple(int id)
    {
        var DBwindowsSimple = await _Context.WindowsSimple.FindAsync(id);
        if (DBwindowsSimple == null)
            return BadRequest("WindowsSimple not found");
        _Context.WindowsSimple.Remove(DBwindowsSimple);
        await _Context.SaveChangesAsync();
        return Ok(await _Context.WindowsSimple.ToListAsync());
    }
}