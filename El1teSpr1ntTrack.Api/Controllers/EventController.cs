
using El1teSpr1ntTrack.Application.Interfaces;
using El1teSpr1ntTrack.Application.Services;
using El1teSpr1ntTrack.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace El1teSpr1ntTrack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetAll()
        {
            var events = await _eventService.GetAllAsync();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetById(int id)
        {
            var ev = await _eventService.GetByIdAsync(id);
            if (ev == null) return NotFound();
            return Ok(ev);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Event ev)
        {
            await _eventService.AddAsync(ev);
            return CreatedAtAction(nameof(GetById), new { id = ev.Id }, ev);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Event ev)
        {
            if (id != ev.Id) return BadRequest();
            await _eventService.UpdateAsync(ev);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ev = await _eventService.GetByIdAsync(id);
            if (ev == null) return NotFound();

            await _eventService.DeleteAsync(ev);
            return NoContent();
        }
    }
}
