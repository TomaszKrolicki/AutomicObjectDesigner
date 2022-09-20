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
    // https://localhost:7017/api/SapJobBwChain

    [ApiController]
    [Route("api/[controller]")]
    public class SapJobBwChainController : ControllerBase
    {
        private readonly ISapJobBwChainRepository _sapJobBwChainRepository;
        private readonly ILogger<SapJobBwChainController> _logger;

        public SapJobBwChainController(ILogger<SapJobBwChainController> logger,
            ISapJobBwChainRepository repository)
        {
            _sapJobBwChainRepository = repository;
            _logger = logger;
        }

        //POST https://localhost:7017/api/SapJobBwChain/step1
        [HttpPost("step1", Name = "CreateSapJobBwChain_Step1")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChain(
            [FromBody] SapJobBwChainStep1Dto SapJobBwChainStep1Dto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapJobBwChain = new SapJobBwChain
            {
                SapSid = SapJobBwChainStep1Dto.SapSid,
                SapClient = SapJobBwChainStep1Dto.SapClient,
                SapJobName = SapJobBwChainStep1Dto.SapJobName,
                DeleteSapJob = SapJobBwChainStep1Dto.DeleteSapJob,
                RoutineJob = SapJobBwChainStep1Dto.RoutineJob,
                ProcessName = SapJobBwChainStep1Dto.ProcessName,
                SapReport = Converter.TextReportConverter(SapJobBwChainStep1Dto.SapReport),
                SapVariant = Converter.TextVariantConverter(SapJobBwChainStep1Dto.SapVariant),
                Kette = Converter.TextKetteConverter(SapJobBwChainStep1Dto.Kette),
                ObjectName =
                    $"<{SapJobBwChainStep1Dto.SapSid}>.<{SapJobBwChainStep1Dto.SapClient}>#<{SapJobBwChainStep1Dto.RoutineJob}>#<{SapJobBwChainStep1Dto.ProcessName}>#<{SapJobBwChainStep1Dto.SapReport}>" +
                    $"$<{SapJobBwChainStep1Dto.SapVariant}>.JOBS"
            };
            _sapJobBwChainRepository.Create(sapJobBwChain);
            await _sapJobBwChainRepository.Save();
            int id = sapJobBwChain.Id;
            Console.WriteLine($"Id = {id}");
            return CreatedAtRoute($"CreateSapJobBwChain_Step1", new { id = sapJobBwChain.Id }, sapJobBwChain);
        }

        // Delete https://localhost:7017/api/SapJobBwChain/{id}
        [HttpDelete("{id:int}", Name = "DeleteSapJobBwChain")]
        public async Task<ActionResult<List<SapJobBwChain>>> DeleteSapJobBwChainStep1(int id)
        {
            var sapObject = new SapJobBwChain() { Id = id };

            _sapJobBwChainRepository.Delete(sapObject);

            _sapJobBwChainRepository.Save();

            return NoContent();
        }


        //Get https://localhost:7017/api/SapJobBwChain
        [HttpGet]
        public async Task<ActionResult<List<SapJobBwChain>>> GetSapJobBwChain()
        {
            _logger.LogInformation("GetSapJobBwChain called...");
            var sapJobBwChain = _sapJobBwChainRepository.GetAll();

            return Ok(sapJobBwChain);
        }

        //Get https://localhost:7017/api/SapJobBwChain/{id}
        [HttpGet("{id:int}", Name = "GetSapJobBwChain")]
        public async Task<ActionResult<SapJobBwChain>> GetSapJobBwChain(int id)
        {
            _logger.LogInformation($"GetSapSobBwChain called with parameter id = {id}");

            var sapJobBwChain = _sapJobBwChainRepository.FindByCondition((h => h.Id == id));

            SapJobBwChainStep2Dto sap = new SapJobBwChainStep2Dto
            {
                Id = id,
                SapVariant = sapJobBwChain.FirstOrDefault().SapVariant,
                SapReport = sapJobBwChain.FirstOrDefault().SapReport,
                ObjectName = sapJobBwChain.FirstOrDefault().ObjectName,
                Kette = sapJobBwChain.FirstOrDefault().Kette
            };

            return Ok(sap);
        }

        // https://localhost:7017/SapJobBwChain/step2
        [HttpPost("step2", Name = "CreateSapJobBwChain_Step2")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChainStep2(
            [FromBody] SapJobBwChainStep2Dto SapJobBwChainStep2Dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapJobBwChainRepository.FindByCondition(x => x.Id == SapJobBwChainStep2Dto.Id).FirstOrDefault();

            if (sapObject == null)
            {
                return NotFound();
            }

            sapObject.SapReport = SapJobBwChainStep2Dto.SapReport;
            sapObject.SapVariant = SapJobBwChainStep2Dto.SapVariant;
            sapObject.Kette = SapJobBwChainStep2Dto.Kette;
            sapObject.ObjectName = SapJobBwChainStep2Dto.ObjectName;

            _sapJobBwChainRepository.Update(sapObject);
            await _sapJobBwChainRepository.Save();

            return CreatedAtRoute("CreateSapJobBwChain_Step2", new { id = sapObject.Id }, sapObject);
        }


        // https://localhost:7017/SapJobBwChain/step3
        [HttpPost("step3", Name = "CreateSapJobBwChain_Step3")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChainStep3(
            [FromBody] SapJobBwChainStep3Dto SapJobBwChainStep3Dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapJobBwChainRepository.FindByCondition(x => x.Id == SapJobBwChainStep3Dto.Id).FirstOrDefault();

            if (sapObject == null)
            {
                return NotFound();
            }

            sapObject.Documentation = SapJobBwChainStep3Dto.Documentation;
            

            _sapJobBwChainRepository.Update(sapObject);
            await _sapJobBwChainRepository.Save();

            return CreatedAtRoute("CreateSapJobBwChain_Step3", new { id = sapObject.Id }, sapObject);
            
        }

        [HttpPost("step4", Name = "CreateSapJobBwChain_Step4")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChainStep4(
            [FromBody] SapJobBwChainStep4Dto SapJobBwChainStep4Dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var sapObject = _sapJobBwChainRepository.FindByCondition(x => x.Id == SapJobBwChainStep4Dto.Id).FirstOrDefault();

            if (sapObject == null)
            {
                return NotFound();
            }

            sapObject.Archive1 = SapJobBwChainStep4Dto.Archive1;
            sapObject.Archive2 = SapJobBwChainStep4Dto.Archive2;
            sapObject.Folder = SapJobBwChainStep4Dto.Folder;
            sapObject.InternalAccount = SapJobBwChainStep4Dto.InternalAccount;
            sapObject.Title = SapJobBwChainStep4Dto.Title;

            _sapJobBwChainRepository.Update(sapObject);
            await _sapJobBwChainRepository.Save();

            return CreatedAtRoute("CreateSapJobBwChain_Step4", new { id = sapObject.Id }, sapObject);
        }
    }
}