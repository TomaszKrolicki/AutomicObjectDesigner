using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Controllers.Functions;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects;
using AutomicObjectDesignerBack.Repository;
using AutomicObjectDesignerBack.Repository.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    // https://localhost:7017/api/SapSimple
    [ApiController]
    [Route("api/[controller]")]
    public class SapSimpleController : ControllerBase
    {
        private readonly ISapSimpleRepository _sapSimpleRepository;
        private readonly ILogger<SapSimpleController> _logger;


        public SapSimpleController(AppDatabaseContext context, ISapSimpleRepository sapSimpleRepository,
            ILogger<SapSimpleController> logger)
        {
            _sapSimpleRepository = sapSimpleRepository;
            _logger = logger;
        }

        //GET https://localhost:7017/api/SapSimple
        [HttpGet]
        public async Task<ActionResult<List<SapSimple>>> GetSapSimple()
        {
            _logger.LogInformation("GetSapSimple called...");
            var sapSimple = _sapSimpleRepository.GetAll();



            return Ok(sapSimple);
        }

        //GET https://localhost:7017/api/SapSimple/{id}
        [HttpGet("{id:int}")]

        public async Task<ActionResult<SapSimple>> GetSapSimple(int id)
        {
            var sapSimple = _sapSimpleRepository.FindByCondition((x => x.Id == id));
            _logger.LogInformation($"GetSapSimple called with parameter id = {id}");

            if (sapSimple == null)
            {
                return NotFound();
            }

            return Ok(sapSimple);
        }

        //POST https://localhost:7017/api/SapSimple/step1
        [HttpPost("step1", Name = "CreateSapSimple_Step1")]
        
        public async Task<ActionResult<List<SapSimple>>> CreateSapSimple([FromBody] SapSimpleStep1Dto SapSimpleStep1Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapSimple = new SapSimple
            {
                SapSid = SapSimpleStep1Dto.SapSid,
                SapClient = SapSimpleStep1Dto.SapClient,
                SapJobName = SapSimpleStep1Dto.SapJobName,
                SapReport = Converter.TextReportConverter(SapSimpleStep1Dto.SapReport),
                SapVariant = Converter.TextVariantConverter(SapSimpleStep1Dto.SapVariant),
                RoutineJob = SapSimpleStep1Dto.RoutineJob,
                DeleteSapJob = SapSimpleStep1Dto.DeleteSapJob,
                ProcessName = SapSimpleStep1Dto.ProcessName,
                ObjectName = $"<{SapSimpleStep1Dto.SapSid}>.<{SapSimpleStep1Dto.SapClient}>#<{SapSimpleStep1Dto.RoutineJob}>#<{SapSimpleStep1Dto.ProcessName}>#<{SapSimpleStep1Dto.SapReport}>" +
                $"$<{SapSimpleStep1Dto.SapVariant}>.JOBS"

            };

            _sapSimpleRepository.Create(sapSimple);
            await _sapSimpleRepository.Save();

            return CreatedAtRoute("CreateSapSimple_Step1", new { id = sapSimple.Id }, sapSimple);
        }

        //POST https://localhost:7017/api/SapSimple/step2
        [HttpPost("step2", Name = "CreateSapSimple_Step2")]

        public async Task<ActionResult<List<SapSimple>>> CreateSapSimple([FromBody] SapSimpleStep2Dto SapSimpleStep2Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapSimpleRepository.FindByCondition(x => x.Id == SapSimpleStep2Dto.Id).FirstOrDefault();

            if (sapObject == null)
            {
                return NotFound();
            }

            sapObject.SapReport = SapSimpleStep2Dto.SapReport;
            sapObject.SapVariant = SapSimpleStep2Dto.SapVariant;
            sapObject.ObjectName = SapSimpleStep2Dto.ObjectName;

            _sapSimpleRepository.Update(sapObject);
            _sapSimpleRepository.Save();

            return CreatedAtRoute("CreateSapSimple_Step2", new { id = sapObject.Id }, sapObject);
        }

        //POST https://localhost:7017/api/SapSimple/step3
        [HttpPost("step3", Name = "CreateSapSimple_Step3")]

        public async Task<ActionResult<List<SapSimple>>> CreateSapSimple([FromBody] SapSimpleStep3Dto SapSimpleStep3Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapSimpleRepository.FindByCondition(x => x.Id == SapSimpleStep3Dto.Id).FirstOrDefault();

            if (sapObject == null)
            {
                return NotFound();
            }

            sapObject.Documentation = SapSimpleStep3Dto.Documentation;

            _sapSimpleRepository.Update(sapObject);
            _sapSimpleRepository.Save();

            return CreatedAtRoute("CreateSapSimple_Step3", new { id = sapObject.Id }, sapObject);
        }

        //POST https://localhost:7017/api/SapSimple/step4
        [HttpPost("step4", Name = "CreateSapSimple_Step4")]

        public async Task<ActionResult<List<SapSimple>>> CreateSapSimple([FromBody] SapSimpleStep4Dto SapSimpleStep4Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapSimpleRepository.FindByCondition(x => x.Id == SapSimpleStep4Dto.Id).FirstOrDefault();

            if (sapObject == null)
            {
                return NotFound();
            }

            sapObject.Archive1 = SapSimpleStep4Dto.Archive1;
            sapObject.Archive2 = SapSimpleStep4Dto.Archive2;
            sapObject.Folder = SapSimpleStep4Dto.Folder;
            sapObject.InternalAccount = SapSimpleStep4Dto.InternalAccount;
            sapObject.Title = SapSimpleStep4Dto.Title;

            _sapSimpleRepository.Update(sapObject);
            _sapSimpleRepository.Save();

            return CreatedAtRoute("CreateSapSimple_Step4", new { id = sapObject.Id }, sapObject);
        }

        ////Put https://localhost:7017/api/SapSimple/{id}
        //[HttpPut("{id}")]
        //public async Task<ActionResult<List<SapSimple>>> UpdateSapSimple([FromBody] SapSimple SapSimple)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var sapSimple = await _sapSimpleRepository.FindByCondition((x => x.Id == SapSimple.Id));

        //    if (sapSimple == null)
        //    {
        //        return NotFound();
        //    }

        //    sapSimple.SapReport = updateSapSimpleDto.SapReport;
        //    sapSimple.SapJobName = updateSapSimpleDto.SapJobName;
        //    sapSimple.SapVariant = updateSapSimpleDto.SapVariant;
        //    sapSimple.Agent = updateSapSimpleDto.Agent;
        //    sapSimple.Active = updateSapSimpleDto.Active;
        //    sapSimple.DeleteSapJob = updateSapSimpleDto.DeleteSapJob;
        //    sapSimple.Folder = updateSapSimpleDto.Folder;
        //    sapSimple.Login = updateSapSimpleDto.Login;
        //    sapSimple.Queue = updateSapSimpleDto.Queue;
        //    sapSimple.MaxParallelTasks = updateSapSimpleDto.MaxParallelTasks;
        //    sapSimple.OwnerId = updateSapSimpleDto.OwnerId;
        //    sapSimple.Process = updateSapSimpleDto.Process;
        //    sapSimple.ProcessName = updateSapSimpleDto.ProcessName;
        //    sapSimple.PreProcess = updateSapSimpleDto.PreProcess;
        //    sapSimple.PostProcess = updateSapSimpleDto.PostProcess;


        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


        // DELETE https://localhost:7017/api/SapSimple/{id}
        [HttpDelete("{id:int}", Name = "DeleteSapSimple")]
        public async Task<ActionResult<List<SapSimple>>> DeleteSapSimple(int id)
        {
            var sapObject = new SapSimple() { Id = id };

            if (sapObject == null)
            {
                return NotFound();
            }

            _sapSimpleRepository.Delete(sapObject);
            _sapSimpleRepository.Save();

            return NoContent();

        }
        
    }
}
