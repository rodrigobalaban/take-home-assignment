using System.Threading.Tasks;

namespace Bank.Services.Interfaces
{
    public interface IResetService
    {
        Task<bool> ResetAsync();
    }
}
