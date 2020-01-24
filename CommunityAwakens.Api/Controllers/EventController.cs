using CommunityAwakens.Application.Services;
using CommunityAwakens.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CommunityAwakens.Api.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetByIdAsync(int id)
        {
            var evnt = await _eventService.GetEventByIdAsync(id);
            return Ok(evnt);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var events = await _eventService.GetAllEventsAsync();
            return Ok(events);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] Event newEvent)
        {
            var newEventId = await _eventService.CreateEventAsync(newEvent);
            return Ok(newEventId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _eventService.DeleteAsync(id);
            return Ok();
        }
    }
}
