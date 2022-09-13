using AutomicObjectDesigner.Models.Objects;
using AutomicObjectDesignerBack.Data;
using AutomicObjectDesignerBack.Models.Objects.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SapVariantCopyController : ControllerBase
    {
        public readonly AppDatabaseContext _context;

        public SapVariantCopyController(AppDatabaseContext context)
        {
            _context = context;
        }

        //GET https://localhost:7017/api/SapVariantCopy
        [HttpGet]
        public async Task<ActionResult<List<SapVariantCopyDto>>> GetSapVariantCopy()
        {
            var sapVariantCopy = await _context.SapVariantCopy.ToListAsync();

            return Ok(sapVariantCopy);
        }

        //GET https://localhost:7017/api/SapVariantCopy/
        [HttpGet("{id:int}", Name = "GetSapVariantCopy")]
        public async Task<ActionResult<SapVariantCopyDto>> GetSapVariantCopy(int id)
        {
            var sapVariantCopy = await _context.SapVariantCopy.FindAsync(id);

            if (sapVariantCopy == null)
            {
                return NotFound();
            }

            return Ok(sapVariantCopy);
        }

        //POST https://localhost:7017/api/SapVariantCopy/create
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<List<SapVariantCopyDto>>> CreateSapVariantCopy([FromBody] SapVariantCopyDto SapVariantCopy)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sapVariantCopy = new SapVariantCopy
            {

            };


            _context.SapVariantCopy.Add(sapVariantCopy);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetSapSimple", new { id = sapVariantCopy.Id }, sapVariantCopy);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SapVariantCopyDto>>> UpdateSapVariantCopy([FromBody] SapVariantCopy updateSapVariantCopyDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var sapVariantCopy = await _context.SapSimple.FindAsync(updateSapVariantCopyDto.Id);

            if (sapVariantCopy == null)
            {
                return NotFound();
            }



            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SapVariantCopyDto>>> DeleteSapSimple(int id)
        {
            var sapVariantCopy = await _context.SapVariantCopy.FindAsync(id);

            if (sapVariantCopy == null)
            {
                return NotFound();
            }

            _context.SapVariantCopy.Remove(sapVariantCopy);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}