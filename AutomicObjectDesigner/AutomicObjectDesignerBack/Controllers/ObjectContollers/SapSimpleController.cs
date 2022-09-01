using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SapSimpleController : ControllerBase
    {
        public readonly AppDatabaseContext _context;

        public SapSimpleController(AppDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        //GET https://localhost:7017/api/SapSimple
        // pobranie danych uzytkownika + validacja
        public async Task<ActionResult<List<SapSimple>>> GetSapSimple()
        {
            var sapSimple = await _context.SapSimple.ToListAsync();

            return Ok(sapSimple);

        }

        [HttpGet("{id:int}", Name = "GetSapSimple")]
        //GET https://localhost:7017/api/SapSimple/
        public async Task<ActionResult<SapSimple>> GetSapSimple(int id)
        {
            var sapSimple = await _context.SapSimple.FindAsync(id);

            if (sapSimple == null)
            {
                return NotFound();
            }

            return Ok(sapSimple);
        }

        //POST https://localhost:7017/api/SapSimple/create
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<List<SapSimple>>> CreateSapSimple([FromBody] SapSimple SapSimple)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapSimple = new SapSimple
            {
                SapSid = SapSimple.SapSid,
                SapClient = SapSimple.SapClient,
                SapReport = SapSimple.SapReport,
                SapJobName = SapSimple.SapJobName,
                SapVariant = SapSimple.SapVariant,
                Agent = SapSimple.Agent,
                Active = SapSimple.Active,
                RoutineJob = SapSimple.RoutineJob,
                DeleteSapJob = SapSimple.DeleteSapJob,
                Folder = SapSimple.Folder,
                Login = SapSimple.Login,
                Queue = SapSimple.Queue,
                MaxParallelTasks = SapSimple.MaxParallelTasks,
                OwnerId = SapSimple.OwnerId,
                Process = SapSimple.Process,
                ProcessName = SapSimple.ProcessName,
                PreProcess = SapSimple.PreProcess,
                PostProcess = SapSimple.PostProcess
            };

            DataService.Current.SapSimples.Add(sapSimple);

            
            _context.CreateSapSimple(sapSimple);
            _context.SaveChanges();

            return CreatedAtRoute("GetSapSimple", new { id = sapSimple.Id }, sapSimple);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SapSimple>>> UpdateSapSimple(int id, [FromBody] UpdateSapSimpleDto updateSapSimpleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var sapSimple = await _context.SapSimple.FindAsync(updateSapSimpleDto.Id);

            if (sapSimple == null)
            {
                return NotFound();
            }

            sapSimple.SapReport = updateSapSimpleDto.SapReport;
            sapSimple.SapJobName = updateSapSimpleDto.SapJobName;
            sapSimple.SapVariant = updateSapSimpleDto.SapVariant;
            sapSimple.Agent = updateSapSimpleDto.Agent;
            sapSimple.Active = updateSapSimpleDto.Active;
            sapSimple.DeleteSapJob = updateSapSimpleDto.DeleteSapJob;
            sapSimple.Folder = updateSapSimpleDto.Folder;
            sapSimple.Login = updateSapSimpleDto.Login;
            sapSimple.Queue = updateSapSimpleDto.Queue;
            sapSimple.MaxParallelTasks = updateSapSimpleDto.MaxParallelTasks;
            sapSimple.OwnerId = updateSapSimpleDto.OwnerId;
            sapSimple.Process = updateSapSimpleDto.Process;
            sapSimple.ProcessName = updateSapSimpleDto.ProcessName;
            sapSimple.PreProcess = updateSapSimpleDto.PreProcess;
            sapSimple.PostProcess = updateSapSimpleDto.PostProcess;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SapSimple>>> DeleteSapSimple(int id)
        {
            var sapSimple = await _context.SapSimple.FindAsync(id);

            if (sapSimple == null)
            {
                return NotFound();
            }

            _context.SapSimple.Remove(sapSimple);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
