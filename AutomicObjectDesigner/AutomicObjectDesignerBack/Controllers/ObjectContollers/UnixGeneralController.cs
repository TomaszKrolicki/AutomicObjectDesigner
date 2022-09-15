//using AutomicObjectDesigner.Models.Objects;
//using AutomicObjectDesignerBack.Data;
//using AutomicObjectDesignerBack.Models.Objects;
//using AutomicObjectDesignerBack.Models.Objects.Dto;
//using AutomicObjectDesignerBack.Models.Update;
//using AutomicObjectDesignerBack.Repository;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class UnixGeneralController : ControllerBase
//    {
//        private readonly IUnixGeneralRepository _unixGeneralRepository;
//        private readonly ILogger<UnixGeneral> _logger;

//        public UnixGeneralController(AppDatabaseContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        //GET https://localhost:7017/api/UnixGeneral
//        // pobranie danych uzytkownika + validacja
//        public async Task<ActionResult<List<UnixGeneralDto>>> GetUnixGeneral()
//        {
//            var unixGeneral = await _context.UnixGeneral.ToListAsync();

//            return Ok(unixGeneral);

//        }

//        [HttpGet("{id:int}", Name = "GetUnixGeneral")]
//        //GET https://localhost:7017/api/UnixGeneral/
//        public async Task<ActionResult<UnixGeneralDto>> GetUnixGeneral(int id)
//        {
//            var unixGeneral = await _context.UnixGeneral.FindAsync(id);

//            if (unixGeneral == null)
//            {
//                return NotFound();
//            }

//            return Ok(unixGeneral);
//        }

//        //POST https://localhost:7017/api/UnixGeneral/create
//        [HttpPost]
//        [Route("create")]
//        public async Task<ActionResult<List<UnixGeneralDto>>> CreateUnixGeneral([FromBody] UnixGeneralDto UnixGeneral)
//        {

//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            var unixGeneral = new UnixGeneral
//            {
//                SapSid = UnixGeneral.SapSid,
//                SapClient = UnixGeneral.SapClient,
//                SapReport = UnixGeneral.SapReport,
//                UnixLogin = UnixGeneral.UnixLogin,
//                UnixServer = UnixGeneral.UnixServer,
//                //Agent = UnixGeneral.Agent,
//                //Active = UnixGeneral.Active,
//                RoutineJob = UnixGeneral.RoutineJob,
//                //Folder = UnixGeneral.Folder,
//                //Login = UnixGeneral.Login,
//                //Queue = UnixGeneral.Queue,
//                //MaxParallelTasks = UnixGeneral.MaxParallelTasks,
//                //OwnerId = UnixGeneral.OwnerId,
//                //Process = UnixGeneral.Process,
//                ProcessName = UnixGeneral.ProcessName,
//                //PreProcess = UnixGeneral.PreProcess,
//                //PostProcess = UnixGeneral.PostProcess
//            };

            

            
//            _context.UnixGeneral.Add(unixGeneral);
//            await _context.SaveChangesAsync();

//            return CreatedAtRoute("GetUnixGeneral", new { id = unixGeneral.Id }, unixGeneral);
//        }

//        [HttpPut("{id}")]
//        public async Task<ActionResult<List<UnixGeneralDto>>> UpdateUnixGeneral([FromBody] UnixGeneral updateUnixGeneral)
//        {

//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            //TODO:
//            var unixGeneral = await _context.UnixGeneral.FindAsync(updateUnixGeneral);

//            if (unixGeneral == null)
//            {
//                return NotFound();
//            }

//            unixGeneral.SapReport = updateUnixGeneral.SapReport;
//            unixGeneral.UnixLogin = updateUnixGeneral.UnixLogin;
//            // unixGeneral.UnixServer = updateUnixGeneral.UnixServer;
//            // unixGeneral.Agent = updateUnixGeneral.Agent;
//            // unixGeneral.Active = updateUnixGeneral.Active;
//            // unixGeneral.Folder = updateUnixGeneral.Folder;
//            // unixGeneral.Login = updateUnixGeneral.Login;
//            // unixGeneral.Queue = updateUnixGeneral.Queue;
//            // unixGeneral.MaxParallelTasks = updateUnixGeneral.MaxParallelTasks;
//            // unixGeneral.OwnerId = updateUnixGeneral.OwnerId;
//            // unixGeneral.Process = updateUnixGeneral.Process;
//            // unixGeneral.ProcessName = updateUnixGeneral.ProcessName;
//            // unixGeneral.PreProcess = updateUnixGeneral.PreProcess;
//            // unixGeneral.PostProcess = updateUnixGeneral.PostProcess;

//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public async Task<ActionResult<List<UnixGeneralDto>>> DeleteUnixGeneral(int id)
//        {
//            var unixGeneral = await _context.UnixGeneral.FindAsync(id);

//            if (unixGeneral == null)
//            {
//                return NotFound();
//            }

//            _context.UnixGeneral.Remove(unixGeneral);
//            await _context.SaveChangesAsync();

//            return NoContent();

//        }
//    }

//}
