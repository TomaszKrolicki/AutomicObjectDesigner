using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Controllers.Functions;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects;
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

        public SapJobBwChainController(AppDatabaseContext context, ILogger<SapJobBwChainController> logger, ISapJobBwChainRepository repository)
        {
            _sapJobBwChainRepository = repository;
            _logger = logger;
        }

        [HttpGet]
        //GET https://localhost:7017/api/SapJobBwChain
        // pobranie danych uzytkownika + validacja
        public async Task<ActionResult<List<SapJobBwChain>>> GetSapJobBwChain()
        {
            throw new NotImplementedException();

        }

        [HttpGet("{id:int}", Name = "GetSapJobBwChain")]
        //GET https://localhost:7017/api/SapJobBwChain/
        public async Task<ActionResult<SapJobBwChain>> GetSapJobBwChain(int id)
        {
            throw new NotImplementedException();
        }

        //POST https://localhost:7017/api/SapJobBwChain/create
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<List<SapJobBwChain>>> CreateSapJobBwChain([FromBody] SapJobBwChainStep1Dto SapJobBwChainStep1Dto)
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
                ObjectName = $"<{SapJobBwChainStep1Dto.SapSid}>.<{SapJobBwChainStep1Dto.SapClient}>#<{SapJobBwChainStep1Dto.RoutineJob}>#<{SapJobBwChainStep1Dto.ProcessName}>#<{SapJobBwChainStep1Dto.SapReport}>" +
                             $"$<{SapJobBwChainStep1Dto.SapVariant}>.JOBS"
            };


            throw new NotImplementedException();

            return CreatedAtRoute("GetSapJobBwChain", new { id = sapJobBwChain.Id }, sapJobBwChain);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SapJobBwChain>>> DeleteSapJobBwChain(int id)
        {
            
            throw new NotImplementedException();

            return NoContent();

        }
    }
}
