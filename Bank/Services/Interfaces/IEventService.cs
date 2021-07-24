using Bank.Models;
using System.Threading.Tasks;

namespace Bank.Services.Interfaces
{
    public interface IEventService
    {
        Task<EventResponse> ProcessEvent(Event @event);
    }
}
