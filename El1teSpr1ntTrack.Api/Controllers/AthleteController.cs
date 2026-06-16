using El1teSpr1ntTrack.Application.Interfaces;
using El1teSpr1ntTrack.Application.Services;
using El1teSpr1ntTrack.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace El1teSpr1ntTrack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AthletesController : ControllerBase
    {
        private readonly IAthleteService _athleteService;

        public AthletesController(IAthleteService athleteService)
        {
            _athleteService = athleteService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Athlete>>> GetAll()
        {
            var athletes = await _athleteService.GetAllAsync();
            return Ok(athletes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Athlete>> GetById(int id)
        {
            var athlete = await _athleteService.GetByIdAsync(id);
            if (athlete == null) return NotFound();
            return Ok(athlete);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Athlete athlete)
        {
            await _athleteService.AddAsync(athlete);
            return CreatedAtAction(nameof(GetById), new { id = athlete.Id }, athlete);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Athlete athlete)
        {
            if (id != athlete.Id) return BadRequest("Mismatched athlete ID");
            await _athleteService.UpdateAsync(athlete);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var athlete = await _athleteService.GetByIdAsync(id);
            if (athlete == null) return NotFound();

            await _athleteService.DeleteAsync(athlete);
            return NoContent();
        }
    }
}
