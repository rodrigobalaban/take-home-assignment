using Bank.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bank.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ResetController : ControllerBase
    {
        private readonly IResetService _resetService;

        public ResetController(IResetService resetService)
        {
            _resetService = resetService;
        }

        [HttpPost]
        public async Task<ActionResult> PostResetAsync()
        {
            await _resetService.ResetAsync();
            return Ok("OK");
        }
    }
}
