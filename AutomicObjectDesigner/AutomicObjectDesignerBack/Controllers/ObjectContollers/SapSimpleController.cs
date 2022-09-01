using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Update;
using AutomicObjectDesignerBack.Models.Create;
using AutomicObjectDesignerBack.Models.Objects;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;

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
        public IActionResult GetSapSimple()
        {
            var sapSimple = DataService.Current.SapSimples;

            return Ok(sapSimple);

        }

        [HttpGet("{id:int}", Name = "GetSapSimple")]
        //GET https://localhost:7017/api/SapSimple/
        public IActionResult GetSapSimple(int id)
        {
            var sapSimple = DataService.Current.SapSimples.FirstOrDefault(c => c.Id == id);

            if (sapSimple == null)
            {
                return NotFound();
            }

            return Ok(sapSimple);
        }

        //POST https://localhost:7017/api/SapSimple/create
        [HttpPost]
        [Route("create")]
        public IActionResult CreateSapSimple([FromBody] SapSimple SapSimple)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //var maxId = DataService.Current.SapSimples.Max(c => c.Id);
            
            var sapSimple = new SapSimple
            {
                //Id = maxId + 1,
                SapSid = SapSimple.SapSid,
                SapClient = SapSimple.SapClient,
                SapReport = SapSimple.SapReport,
                SapJobName = SapSimple.SapJobName,
                SapVariant = SapSimple.SapVariant,
                Agent = SapSimple.Agent,
                Active = SapSimple.Active,
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

            // var sapSimple = new SapSimple
            // {
            //     SapSid = values["SapSid"],
            //     SapClient = values["SapClient"],
            //     SapReport = values["SapReport"],
            //     SapJobName = values["SapJobName"],
            //     SapVariant = values["SapVariant"],
            //     Agent = values["Agent"],
            //     Active = Convert.ToBoolean(values["Active"]),
            //     DeleteSapJob = Convert.ToBoolean(values["DeleteSapJob"]),
            //     Folder = values["Folder"],
            //     Login = values["Login"],
            //     Queue = values["Queue"],
            //     MaxParallelTasks = Convert.ToInt16(values["MaxParallelTasks"]),
            //     OwnerId = Convert.ToInt16(values["OwnerId"]),
            //     Process = values["Process"],
            //     ProcessName = values["ProcessName"],
            //     PreProcess = values["PreProcess"],
            //     PostProcess = values["PostProcess"]
            // };
            DataService.Current.SapSimples.Add(sapSimple);

            
            _context.CreateSapSimple(sapSimple);
            _context.SaveChanges();

            return CreatedAtRoute("GetSapSimple", new { id = sapSimple.Id }, sapSimple);
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdateSapSimple(int id, [FromBody] UpdateSapSimpleDto updateSapSimpleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var sapSimple = DataService.Current.SapSimples.FirstOrDefault(c => c.Id == id);

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

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSapSimple(int id)
        {
            var sapSimple = DataService.Current.SapSimples.FirstOrDefault(c => c.Id == id);

            if (sapSimple == null)
            {
                return NotFound();
            }

            DataService.Current.SapSimples.Remove(sapSimple);
            return NoContent();

        }
    }
}
