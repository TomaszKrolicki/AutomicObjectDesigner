using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Controllers.Functions;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects;
//using AutomicObjectDesignerBack.Models.Objects.Dto;
using AutomicObjectDesignerBack.Models.Update;
using AutomicObjectDesignerBack.Repository;
using AutomicObjectDesignerBack.Repository.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    // https://localhost:7017/api/WindowsGeneral
    [ApiController]
    [Route("api/[controller]")]
    public class WindowsGeneralController : ControllerBase
    {
        private readonly IWindowsGeneralRepository _windowsGeneralRepository;
        private readonly ILogger<WindowsGeneralController> _logger;

        public WindowsGeneralController(AppDatabaseContext context, ILogger<WindowsGeneralController> logger,
            IWindowsGeneralRepository repository)
        {
            _windowsGeneralRepository = repository;
            _logger = logger;
        }

        //GET https://localhost:7017/api/WindowsGeneral
        [HttpGet]
        public async Task<ActionResult<List<WindowsGeneral>>> GetWindowsGeneral()
        {
            _logger.LogInformation("GetWindowsGeneral called...");
            var windowsGeneral = _windowsGeneralRepository.GetAll();

            return Ok(windowsGeneral);

        }

        //GET https://localhost:7017/api/WindowsGeneral/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<WindowsGeneral>> GetWindowsGeneral(int id)
        {
            _logger.LogInformation($"GetWindowsGeneral called with parameter id = {id}");
            var windowsGeneral = _windowsGeneralRepository.FindByCondition((x => x.Id == id));

            if (windowsGeneral == null)
            {
                return NotFound();
            }

            return Ok(windowsGeneral);
        }

        //DELETE https://localhost:7017/api/WindowsGeneral/{id}
        [HttpDelete("{id}", Name = "DeleteWindowsGeneral")]
        public async Task<ActionResult<List<WindowsGeneral>>> DeleteWindowsGeneral(int id)
        {
            var winObject = new WindowsGeneral() { Id = id };


            if (winObject == null)
            {
                return NotFound();
            }

            _windowsGeneralRepository.Delete(winObject);
            _windowsGeneralRepository.Save();

            return NoContent();

        }

        //POST https://localhost:7017/api/WindowsGeneral/step1
        [HttpPost("step1", Name = "CreateWindowsGeneral_Step1")]
        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneral([FromBody] WindowsGeneralStep1Dto WindowsGeneralStep1Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsGeneral = new WindowsGeneral
            {
                WinLogin = WindowsGeneralStep1Dto.WinLogin,
                WinServer = WindowsGeneralStep1Dto.WinServer,
                SapSid = WindowsGeneralStep1Dto.SapSid,
                SapClient = WindowsGeneralStep1Dto.SapClient,
                RoutineJob = WindowsGeneralStep1Dto.RoutineJob,
                ProcessName = WindowsGeneralStep1Dto.ProcessName,
                NameSuffix = WindowsGeneralStep1Dto.NameSuffix,
                ObjectName = $"<{WindowsGeneralStep1Dto.SapSid}>.<{WindowsGeneralStep1Dto.SapClient}>#<{WindowsGeneralStep1Dto.RoutineJob}>" +
                             $"#<{WindowsGeneralStep1Dto.ProcessName}>#WIN_<{WindowsGeneralStep1Dto.NameSuffix}>.JOBS"

            };

            _windowsGeneralRepository.Create(windowsGeneral);
            await _windowsGeneralRepository.Save();

            return CreatedAtRoute("CreateWindowsGeneral_Step1", new { id = windowsGeneral.Id }, windowsGeneral);
        }

        //POST https://localhost:7017/api/WindowsGeneral/step2
        [HttpPost("step2", Name = "CreateWindowsGeneral_Step2")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep2([FromBody] WindowsGeneralStep2Dto WindowsGeneralStep2Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep2Dto.Id);
            var windowsJob = new WindowsGeneralStep2Dto()
            {
                ObjectName = WindowsGeneralStep2Dto.ObjectName
            };

            throw new NotImplementedException();
            //_windowsGeneralRepository.Update(windowsJob);
            //_windowsGeneralRepository.Save();

            //return CreatedAtRoute("CreateWindowsGeneral_Step2", new { id = windowsJob.Id }, windowsJob);
        }

        //POST https://localhost:7017/api/WindowsGeneral/step3
        [HttpPost("step3", Name = "CreateWindowsGeneral_Step3")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep3([FromBody] WindowsGeneralStep3Dto WindowsGeneralStep3Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep3Dto.Id);
            var windowsJob = new WindowsGeneralStep3Dto()
            {
                Process = WindowsGeneralStep3Dto.Process
            };

            throw new NotImplementedException();
        }

        //POST https://localhost:7017/api/WindowsGeneral/step4
        [HttpPost("step4", Name = "CreateWindowsGeneral_Step4")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep4([FromBody] WindowsGeneralStep4Dto WindowsGeneralStep4Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep4Dto.Id);
            var windowsJob = new WindowsGeneralStep4Dto()
            {
                Documentation = WindowsGeneralStep4Dto.Documentation
            };

            throw new NotImplementedException();
        }

        //POST https://localhost:7017/api/WindowsGeneral/step5
        [HttpPost("step5", Name = "CreateWindowsGeneral_Step5")]

        public async Task<ActionResult<List<WindowsGeneral>>> CreateWindowsGeneralStep5([FromBody] WindowsGeneralStep5Dto WindowsGeneralStep5Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var windowsObject = _windowsGeneralRepository.FindByCondition(x => x.Id == WindowsGeneralStep5Dto.Id);
            var windowsJob = new WindowsGeneralStep5Dto()
            {
                Archive1 = WindowsGeneralStep5Dto.Archive1,
                Archive2 = WindowsGeneralStep5Dto.Archive2,
                Folder = WindowsGeneralStep5Dto.Folder,
                InternalAccount = WindowsGeneralStep5Dto.InternalAccount,
                Title = WindowsGeneralStep5Dto.Title
            };

            throw new NotImplementedException();
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<List<WindowsGeneralDto>>> UpdateWindowsGeneral([FromBody] WindowsGeneral updateWindowsGeneral)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    //TODO:
        //    var windowsGeneral = await _context.WindowsGeneral.FindAsync(updateWindowsGeneral);

        //    if (windowsGeneral == null)
        //    {
        //        return NotFound();
        //    }


        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


    }

}
