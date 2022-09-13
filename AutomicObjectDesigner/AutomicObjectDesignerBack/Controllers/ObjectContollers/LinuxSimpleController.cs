using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects.Dto;
using AutomicObjectDesignerBack.Models.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinuxSimpleController : ControllerBase
    {
        public readonly AppDatabaseContext _context;

        public LinuxSimpleController(AppDatabaseContext context)
        {
            _context = context;
        }

        //GET https://localhost:7017/api/LinuxSimple
        [HttpGet]
        public async Task<ActionResult<List<LinuxSimpleDto>>> GetLinuxSimple()
        {
            var linuxSimple = await _context.LinuxSimple.ToListAsync();

            return Ok(linuxSimple);
        }

        //GET https://localhost:7017/api/LinuxSimple/
        [HttpGet("{id:int}", Name = "GetLinuxSimple")]
        public async Task<ActionResult<LinuxSimpleDto>> GetLinuxSimple(int id)
        {
            var linuxSimple = await _context.LinuxSimple.FindAsync(id);

            if (linuxSimple == null)
            {
                return NotFound();
            }

            return Ok(linuxSimple);
        }

        //POST https://localhost:7017/api/LinuxSimple/create
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<List<LinuxSimpleDto>>> CreateLinuxSimple([FromBody] LinuxSimpleDto LinuxSimple)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var linuxSimple = new LinuxSimple
            {
            };


            _context.LinuxSimple.Add(linuxSimple);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetLinuxSimple", new { id = linuxSimple.Id }, linuxSimple);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<LinuxSimpleDto>>> UpdateLinuxSimple([FromBody] LinuxSimple updateLinuxSimple)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var linuxSimple = await _context.LinuxSimple.FindAsync(updateLinuxSimple.Id);

            if (linuxSimple == null)
            {
                return NotFound();
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<LinuxSimpleDto>>> DeleteLinuxSimple(int id)
        {
            var linuxSimple = await _context.LinuxSimple.FindAsync(id);

            if (linuxSimple == null)
            {
                return NotFound();
            }

            _context.LinuxSimple.Remove(linuxSimple);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}