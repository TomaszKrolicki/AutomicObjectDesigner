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
    [ApiController]
    [Route("api/[controller]")]
    public class SapJobBwChainController : ControllerBase
    {
        private readonly ISapJobBwChainRepository _sapJobBwChainRepository;
        private readonly ILogger<SapJobBwChainController> _logger;

        public SapJobBwChainController(AppDatabaseContext context, ILogger<SapJobBwChainController> logger,
            ISapJobBwChainRepository repository)
        {
            _sapJobBwChainRepository = repository;
            _logger = logger;
        }

        //POST https://localhost:7017/api/SapJobBwChain/1
        [HttpPost(Name = "CreateSapJobBwChain/1")]
        [Route("1")]
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

            return CreatedAtRoute("CreateSapJobBwChain/1", new { id = sapJobBwChain.Id }, sapJobBwChain);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SapJobBwChain>>> DeleteSapJobBwChainStep1(int id)
        {
            var sapObject = new SapJobBwChain() { Id = id };

            _sapJobBwChainRepository.Delete(sapObject);

            _sapJobBwChainRepository.Save();

            return NoContent();

        }

        //Get https://localhost:7017/api/SapJobBwChain/1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<SapJobBwChain>> GetSapJobBwChain(int id)
        {
            _logger.LogInformation($"GetSapSobBwChain called with parameter id = {id}");

            var SapJobBwChain = _sapJobBwChainRepository.FindByCondition((h => h.Id == id));

            return Ok(SapJobBwChain);
        }

        [HttpPut(Name = "CreateSapJobBwChain/2")]
        [Route("CreateSapJobBwChain/2")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChainStep2(
            [FromBody] SapJobBwChainStep2Dto SapJobBwChainStep2Dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapJobBwChainRepository.FindByCondition(x => x.Id == SapJobBwChainStep2Dto.Id);


            var sapJob = new SapJobBwChainStep2Dto()
            {
                SapReport = SapJobBwChainStep2Dto.SapReport,
                SapVariant = SapJobBwChainStep2Dto.SapVariant,
                Kette = SapJobBwChainStep2Dto.Kette,
                ObjectName = SapJobBwChainStep2Dto.ObjectName
            };

            throw new NotImplementedException();
            //_sapJobBwChainRepository.Update();
            //_sapJobBwChainRepository.Save();

            //return CreatedAtRoute("CreateSapJobBwChain/2", new { id = sapJobBwChain.Id }, sapJobBwChain);
        }


        [HttpPut(Name = "CreateSapJobBwChain/3")]
        [Route("CreateSapJobBwChain/3")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChainStep3(
            [FromBody] SapJobBwChainStep3Dto SapJobBwChainStep3Dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapJobBwChainRepository.FindByCondition(x => x.Id == SapJobBwChainStep3Dto.Id);


            var sapJob = new SapJobBwChainStep3Dto()
            {
                Documentation = SapJobBwChainStep3Dto.Documentation
            };

            throw new NotImplementedException();
            //_sapJobBwChainRepository.Update();
            //_sapJobBwChainRepository.Save();

            //return CreatedAtRoute("CreateSapJobBwChain/3", new { id = sapJobBwChain.Id }, sapJobBwChain);
        }

        [HttpPut(Name = "CreateSapJobBwChain/4")]
        [Route("CreateSapJobBwChain/4")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChainStep4(
            [FromBody] SapJobBwChainStep4Dto SapJobBwChainStep4Dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapObject = _sapJobBwChainRepository.FindByCondition(x => x.Id == SapJobBwChainStep4Dto.Id);


            var sapJob = new SapJobBwChainStep4Dto()
            {
                Archive1 = SapJobBwChainStep4Dto.Archive1,
                Archive2 = SapJobBwChainStep4Dto.Archive2,
                Folder = SapJobBwChainStep4Dto.Folder,
                InternalAccount = SapJobBwChainStep4Dto.InternalAccount,
                Title = SapJobBwChainStep4Dto.Title
            };

            throw new NotImplementedException();
            //_sapJobBwChainRepository.Update();
            //_sapJobBwChainRepository.Save();

            //return CreatedAtRoute("CreateSapJobBwChain/3", new { id = sapJobBwChain.Id }, sapJobBwChain);
        }
    }
}
