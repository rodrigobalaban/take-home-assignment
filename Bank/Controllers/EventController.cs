using Bank.Models;
using Bank.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Bank.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task<ActionResult> PostEventAsync(Event @event)
        {
            var response = await _eventService.ProcessEvent(@event);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
