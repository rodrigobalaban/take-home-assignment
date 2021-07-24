using Bank.Models;
using Bank.Services.Interfaces;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class EventService : IEventService
    {
        private readonly IAccountService _accountService;

        public EventService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public Task<DestinationAccount> ProcessEvent(Event @event)
        {
            return @event.Type switch
            {
                "deposit" => DepositAsync(@event),
                _ => null,
            };
        }

        private async Task<DestinationAccount> DepositAsync(Event @event)
        {
            var account = await _accountService.GetAccountByIdAsync(@event.Destination);

            if (account == null)
            {
                account = await _accountService.CreateNewAccountAsync(@event.Destination, @event.Amount);
            }
            else
            {
                account.Balance += @event.Amount;
                await _accountService.UpdateAccountAsync(account);
            }

            return new DestinationAccount(account);
        }
    }
}
