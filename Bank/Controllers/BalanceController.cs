using Bank.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bank.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BalanceController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult> GetBalanceAccount(string account_id)
        {
            var account = await _accountService.GetAccountByIdAsync(account_id);
            
            if (account == null)
            {
                return NotFound(0);
            }

            return Ok(account.Balance);
        }
    }
}
