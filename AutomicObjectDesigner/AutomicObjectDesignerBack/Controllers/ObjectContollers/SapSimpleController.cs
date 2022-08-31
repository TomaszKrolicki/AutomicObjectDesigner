using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Models.Update;
using AutomicObjectDesignerBack.Models.Create;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SapSimpleController : ControllerBase
    {
        [HttpGet]
        //GET https://localhost:7017/api/SapSimple
        // pobranie danych uzytkownika + validacja
        public IActionResult GetSapSimples()
        {
            var sapSimple = DataService.Current.SapSimples;

            return Ok(sapSimple);

        }

        [HttpGet("{id:int}", Name = "GetSapSimple")]
        //GET https://localhost:7017/api/SapSimple/1
        public IActionResult GetSapSimple(int id)
        {
            var sapSimple = DataService.Current.SapSimples.FirstOrDefault(c => c.Id == id);

            if (sapSimple == null)
            {
                return NotFound();
            }

            return Ok(sapSimple);
        }

        //GET https://localhost:7017/api/SapSimple
        [HttpPost]
        public IActionResult CreateSapSimple([FromBody] CreateSapSimple createSapSimple)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var maxId = DataService.Current.SapSimples.Max(c => c.Id);

            var sapSimple = new SapSimple
            {
                Id = maxId + 1,
                SapReport = createSapSimple.SapReport,
                SapJobName = createSapSimple.SapJobName,
                SapVariant = createSapSimple.SapVariant,
                Agent = createSapSimple.Agent,
                Active = createSapSimple.Active,
                DeleteSapJob = createSapSimple.DeleteSapJob,
                Folder = createSapSimple.Folder,
                Login = createSapSimple.Login,
                Queue = createSapSimple.Queue,
                MaxParallelTasks = createSapSimple.MaxParallelTasks,
                OwnerId = createSapSimple.OwnerId,
                Process = createSapSimple.Process,
                ProcessName = createSapSimple.ProcessName,
                PreProcess = createSapSimple.PreProcess,
                PostProcess = createSapSimple.PostProcess

            };
            DataService.Current.SapSimples.Add(sapSimple);

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
