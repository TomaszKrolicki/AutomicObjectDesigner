using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects;
using AutomicObjectDesignerBack.Models.Objects.Dto;
using AutomicObjectDesignerBack.Models.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SapJobBwChainController : ControllerBase
    {
        public readonly AppDatabaseContext _context;

        public SapJobBwChainController(AppDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        //GET https://localhost:7017/api/SapJobBwChain
        // pobranie danych uzytkownika + validacja
        public async Task<ActionResult<List<SapJobBWChainDto>>> GetSapJobBwChain()
        {
            var sapJobBwChain = await _context.SapJobBwChains.ToListAsync();

            return Ok(sapJobBwChain);

        }

        [HttpGet("{id:int}", Name = "GetSapJobBwChain")]
        //GET https://localhost:7017/api/SapJobBwChain/
        public async Task<ActionResult<SapJobBWChainDto>> GetSapJobBwChain(int id)
        {
            var sapJobBwChain = await _context.SapJobBwChains.FindAsync(id);

            if (sapJobBwChain == null)
            {
                return NotFound();
            }

            return Ok(sapJobBwChain);
        }

        //POST https://localhost:7017/api/SapJobBwChain/create
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<List<SapJobBWChainDto>>> CreateSapJobBwChain([FromBody] SapJobBWChainDto SapJobBwChain)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapJobBwChain = new SapJobBwChain
            {
                SapSid = SapJobBwChain.SapSid,
                SapClient = SapJobBwChain.SapClient,
                SapKette = SapJobBwChain.SapKette,
                SapJobName = SapJobBwChain.SapJobName,
                DeleteSapJob = SapJobBwChain.DeleteSapJob,
                //Agent = SapJobBwChain.Agent,
                //Active = SapJobBwChain.Active,
                RoutineJob = SapJobBwChain.RoutineJob,
                //Folder = SapJobBwChain.Folder,
                //Login = SapJobBwChain.Login,
                //Queue = SapJobBwChain.Queue,
                //MaxParallelTasks = SapJobBwChain.MaxParallelTasks,
                //OwnerId = SapJobBwChain.OwnerId,
                //Process = SapJobBwChain.Process,
                ProcessName = SapJobBwChain.ProcessName,
                //PreProcess = SapJobBwChain.PreProcess,
                //PostProcess = SapJobBwChain.PostProcess
            };




            _context.SapJobBwChain.Add(sapJobBwChain);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetSapJobBwChain", new { id = sapJobBwChain.Id }, sapJobBwChain);
        }

        

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SapJobBWChainDto>>> DeleteSapJobBwChain(int id)
        {
            var sapJobBwChain = await _context.SapJobBwChains.FindAsync(id);

            if (sapJobBwChain == null)
            {
                return NotFound();
            }

            _context.SapJobBwChain.Remove(sapJobBwChain);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
