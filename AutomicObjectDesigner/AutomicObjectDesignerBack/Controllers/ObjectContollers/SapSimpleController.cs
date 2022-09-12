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
    public class SapSimpleController : ControllerBase
    {
        public readonly AppDatabaseContext _context;
        private readonly ISapSimpleRepository _sapSimpleRepository;
        private readonly ILogger<SapSimpleController> _logger;


        public SapSimpleController(AppDatabaseContext context, ISapSimpleRepository sapSimpleRepository, ILogger<SapSimpleController> logger)
        {
            _context = context;
            _sapSimpleRepository = sapSimpleRepository;
            this._logger = logger;
        }

        //GET https://localhost:7017/api/SapSimple
        // pobranie danych uzytkownika + validacja
        [HttpGet]
        public async Task<ActionResult<List<SapSimpleStep1Dto>>> GetSapSimple()
        {
            // var sapSimple = await _context.SapSimple.ToListAsync();
            var sapSimple =  _sapSimpleRepository.GetAll();
            _logger.LogInformation("GetSapSimple called...");

            //var sapSimple = await _context.SapSimple.ToListAsync();

            return Ok(sapSimple);
        }

        //GET https://localhost:7017/api/SapSimple/
        [HttpGet("{id:int}", Name = "GetSapSimple")]
        public async Task<ActionResult<SapSimpleStep1Dto>> GetSapSimple(int id)
        {
            var sapSimple = await _context.SapSimple.FindAsync(id);
            

            if (sapSimple == null)
            {
                return NotFound();
            }

            return Ok(sapSimple);
        }

        ////GET https://localhost:7017/api/SapSimple/
        //[HttpGet("{id:int}", Name = "GetSapSimple/{int Step}/{int id}")]
        //public async Task<ActionResult<SapSimpleStep1Dto>> GetSapSimple(int step, int id)
        //{
        //    var sapSimple = await _context.SapSimple.FindAsync(id);
        //    if  (step == 2)
        //    {
        //        var ObjectName =
        //            $"<{sapSimple.SapSid}>.<{sapSimple.SapClient}>#<{sapSimple.RoutineJob}>#<{sapSimple.ProcessName}>#<{sapSimple.SapReport}>" +
        //            $"$<{sapSimple.SapVariant}>.JOBS ";
        //    }
        //    else if (step == 3)
        //    {
        //        return Ok(sapSimple);
        //    }
        //    else if (step == 4)
        //    {
        //        return Ok(sapSimple);
        //    }
        //    return Ok(sapSimple);

        //    if (sapSimple == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(sapSimple);
        //}

        //POST https://localhost:7017/api/SapSimple/create
        [HttpPost]
        [Route("create")]
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
                SapReport = Converter.TextReportConverter(SapSimpleStep1Dto.SapReport),
                SapVariant = Converter.TextVariantConverter(SapSimpleStep1Dto.SapVariant),
                RoutineJob = SapSimpleStep1Dto.RoutineJob,
                DeleteSapJob = SapSimpleStep1Dto.DeleteSapJob,
                ProcessName = SapSimpleStep1Dto.ProcessName,
                ObjectName = $"<{SapSimpleStep1Dto.SapSid}>.<{SapSimpleStep1Dto.SapClient}>#<{SapSimpleStep1Dto.RoutineJob}>#<{SapSimpleStep1Dto.ProcessName}>#<{Converter.TextReportConverter(SapSimpleStep1Dto.SapReport)}>" +
                $"$<{SapSimpleStep1Dto.SapVariant}>.JOBS ",
                SapJobName = SapSimpleStep1Dto.SapJobName,
                



                //SapSid = SapSimple.SapSid,
                //SapClient = SapSimple.SapClient,
                //SapReport = SapSimple.SapReport,
                //SapJobName = SapSimple.SapJobName,
                //SapVariant = SapSimple.SapVariant,
                ////Agent = SapSimple.Agent,
                ////Active = SapSimple.Active,
                //RoutineJob = SapSimple.RoutineJob,
                //DeleteSapJob = SapSimple.DeleteSapJob,
                ////Folder = SapSimple.Folder,
                ////Login = SapSimple.Login,
                ////Queue = SapSimple.Queue,
                ////MaxParallelTasks = SapSimple.MaxParallelTasks,
                ////OwnerId = SapSimple.OwnerId,
                ////Process = SapSimple.Process,
                //ProcessName = SapSimple.ProcessName,
                ////PreProcess = SapSimple.PreProcess,
                ////PostProcess = SapSimple.PostProcess
                //SapReport1 = SapSimple.SapReport1,

                //SapVariant1 = SapSimple.SapVariant1,
                //ObjectName = $"<{SapSimple.SapSid}>.<{SapSimple.SapClient}>#<{SapSimple.RoutineJob}>#<{SapSimple.ProcessName}>#<{SapSimple.SapReport}>" +
                //             $"$<{SapSimple.SapVariant}>.JOBS "


            };


            //DataService.Current.SapSimples.Add(sapSimple);

            _sapSimpleRepository.Create(sapSimple);
            await _sapSimpleRepository.Save();
            // _context.SapSimple.Add(sapSimple);
            // await _context.SaveChangesAsync();

            return CreatedAtRoute("GetSapSimple", new { id = sapSimple.Id }, sapSimple);
        }
        ////POST https://localhost:7017/api/SapSimple/create
        //[HttpPost]
        //[Route("create")]
        //public async Task<ActionResult<List<SapSimple>>> CreateSapSimple([FromBody] SapSimpleStep2Dto SapSimpleStep2Dto)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var sapSimple = new SapSimple
        //    {
        //        ObjectName = SapSimpleStep2Dto.ObjectName,
        //        SapReport1 = SapSimpleStep2Dto.SapReport1,
        //        SapVariant1 = SapSimpleStep2Dto.SapVariant1

        //    };

        //    _context.SapSimple.Add(sapSimple);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtRoute("GetSapSimple", new { id = sapSimple.Id }, sapSimple);
        //}

        ////POST https://localhost:7017/api/SapSimple/create
        //[HttpPost]
        //[Route("create")]
        //public async Task<ActionResult<List<SapSimple>>> CreateSapSimple([FromBody] SapSimpleStep3Dto SapSimpleStep3Dto)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var sapSimple = new SapSimple
        //    {
        //        Documentation = SapSimpleStep3Dto.Documentation
        //    };

        //    _context.SapSimple.Add(sapSimple);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtRoute("GetSapSimple", new { id = sapSimple.Id }, sapSimple);
        //}



        [HttpPut("{id}")]
        public async Task<ActionResult<List<SapSimpleStep1Dto>>> UpdateSapSimple( [FromBody] UpdateSapSimpleDto updateSapSimpleDto)
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
        public async Task<ActionResult<List<SapSimpleStep1Dto>>> DeleteSapSimple(int id)
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
