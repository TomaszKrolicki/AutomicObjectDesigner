using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Controllers.Functions;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects;
using AutomicObjectDesignerBack.Models.Objects.Dto;
using AutomicObjectDesignerBack.Models.Update;
using AutomicObjectDesignerBack.Repository;
using AutomicObjectDesignerBack.Repository.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    // https://localhost:7017/api/UnixGeneral
    [ApiController]
    [Route("api/[controller]")]
    public class UnixGeneralController : ControllerBase
    {
        private readonly IUnixGeneralRepository _unixGeneralRepository;
        private readonly ILogger<UnixGeneralController> _logger;

        public UnixGeneralController(AppDatabaseContext context, ILogger<UnixGeneralController> logger,
            IUnixGeneralRepository repository)
        {
            _unixGeneralRepository = repository;
            _logger = logger;
        }

        //GET https://localhost:7017/api/UnixGeneral
        [HttpGet]
        public async Task<ActionResult<List<UnixGeneral>>> GetUnixGeneral()
        {
            _logger.LogInformation("GetUnixGeneral called...");
            var unixGeneral = _unixGeneralRepository.GetAll();

            return Ok(unixGeneral);

        }

        //GET https://localhost:7017/api/UnixGeneral/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<UnixGeneral>> GetUnixGeneral(int id)
        {
            _logger.LogInformation($"GetUnixGeneral called with parameter id = {id}");
            var unixGeneral = _unixGeneralRepository.FindByCondition((x => x.Id == id));

            if (unixGeneral == null)
            {
                return NotFound();
            }

            return Ok(unixGeneral);
        }

        //DELETE https://localhost:7017/api/UnixGeneral/{id}
        [HttpDelete("{id}", Name = "DeleteUnixGeneral")]
        public async Task<ActionResult<List<UnixGeneral>>> DeleteUnixGeneral(int id)
        {
            var unixObject = new UnixGeneral() { Id = id };


            if (unixObject == null)
            {
                return NotFound();
            }

            _unixGeneralRepository.Delete(unixObject);
            _unixGeneralRepository.Save();

            return NoContent();

        }

        //POST https://localhost:7017/api/UnixGeneral/step1
        [HttpPost("step1", Name = "CreateUnixGeneral_Step1")]
        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneral([FromBody] UnixGeneralStep1Dto UnixGeneralStep1Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixGeneral = new UnixGeneral
            {
                UnixServer = UnixGeneralStep1Dto.UnixServer,
                UnixLogin = UnixGeneralStep1Dto.UnixLogin,
                SapSid = UnixGeneralStep1Dto.SapSid,
                SapClient = UnixGeneralStep1Dto.SapClient,
                RoutineJob = UnixGeneralStep1Dto.RoutineJob,
                ProcessName = UnixGeneralStep1Dto.ProcessName,
                NameSuffix = UnixGeneralStep1Dto.NameSuffix,
                ObjectName = $"<{UnixGeneralStep1Dto.SapSid}>.<{UnixGeneralStep1Dto.SapClient}>#<{UnixGeneralStep1Dto.RoutineJob}>" +
                             $"#<{UnixGeneralStep1Dto.ProcessName}>#LNX_<{UnixGeneralStep1Dto.NameSuffix}>.JOBS"

            };

            _unixGeneralRepository.Create(unixGeneral);
            await _unixGeneralRepository.Save();

            return CreatedAtRoute("CreateUnixGeneral_Step1", new { id = unixGeneral.Id }, unixGeneral);
        }

        //POST https://localhost:7017/api/UnixGeneral/step2
        [HttpPost("step2", Name = "CreateUnixGeneral_Step2")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep2([FromBody] UnixGeneralStep2Dto UnixGeneralStep2Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x => x.Id == UnixGeneralStep2Dto.Id);
            var unixJob = new UnixGeneralStep2Dto()
            {
                ObjectName = UnixGeneralStep2Dto.ObjectName
            };

            throw new NotImplementedException();
        }

        //POST https://localhost:7017/api/UnixGeneral/step3
        [HttpPost("step3", Name = "CreateUnixGeneral_Step3")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep3([FromBody] UnixGeneralStep3Dto UnixGeneralStep3Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x => x.Id == UnixGeneralStep3Dto.Id);
            var unixJob = new UnixGeneralStep3Dto()
            {
                Process = UnixGeneralStep3Dto.Process
            };

            throw new NotImplementedException();
        }

        //POST https://localhost:7017/api/UnixGeneral/step4
        [HttpPost("step4", Name = "CreateUnixGeneral_Step4")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep4([FromBody] UnixGeneralStep4Dto UnixGeneralStep4Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x => x.Id == UnixGeneralStep4Dto.Id);
            var unixJob = new UnixGeneralStep4Dto()
            {
                Documentation = UnixGeneralStep4Dto.Documentation
            };

            throw new NotImplementedException();
        }

        //POST https://localhost:7017/api/UnixGeneral/step5
        [HttpPost("step5", Name = "CreateUnixGeneral_Step5")]

        public async Task<ActionResult<List<UnixGeneral>>> CreateUnixGeneralStep5([FromBody] UnixGeneralStep5Dto UnixGeneralStep5Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unixObject = _unixGeneralRepository.FindByCondition(x => x.Id == UnixGeneralStep5Dto.Id);
            var unixJob = new UnixGeneralStep5Dto()
            {
                Archive1 = UnixGeneralStep5Dto.Archive1,
                Archive2 = UnixGeneralStep5Dto.Archive2,
                Folder = UnixGeneralStep5Dto.Folder,
                InternalAccount = UnixGeneralStep5Dto.InternalAccount,
                Title = UnixGeneralStep5Dto.Title
            };

            throw new NotImplementedException();
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<List<UnixGeneralDto>>> UpdateUnixGeneral([FromBody] UnixGeneral updateUnixGeneral)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    //TODO:
        //    var unixGeneral = await _context.UnixGeneral.FindAsync(updateUnixGeneral);

        //    if (unixGeneral == null)
        //    {
        //        return NotFound();
        //    }

        //    unixGeneral.SapReport = updateUnixGeneral.SapReport;
        //    unixGeneral.UnixLogin = updateUnixGeneral.UnixLogin;
        //    unixGeneral.UnixServer = updateUnixGeneral.UnixServer;
        //    unixGeneral.Agent = updateUnixGeneral.Agent;
        //    unixGeneral.Active = updateUnixGeneral.Active;
        //    unixGeneral.Folder = updateUnixGeneral.Folder;
        //    unixGeneral.Login = updateUnixGeneral.Login;
        //    unixGeneral.Queue = updateUnixGeneral.Queue;
        //    unixGeneral.MaxParallelTasks = updateUnixGeneral.MaxParallelTasks;
        //    unixGeneral.OwnerId = updateUnixGeneral.OwnerId;
        //    unixGeneral.Process = updateUnixGeneral.Process;
        //    unixGeneral.ProcessName = updateUnixGeneral.ProcessName;
        //    unixGeneral.PreProcess = updateUnixGeneral.PreProcess;
        //    unixGeneral.PostProcess = updateUnixGeneral.PostProcess;

        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


    }

}
