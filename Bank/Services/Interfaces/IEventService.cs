using Bank.Models;
using System.Threading.Tasks;

namespace Bank.Services.Interfaces
{
    public interface IEventService
    {
        Task<DestinationAccount> ProcessEvent(Event @event);
    }
}
