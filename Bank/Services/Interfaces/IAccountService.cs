using Bank.Models;
using System.Threading.Tasks;

namespace Bank.Services.Interfaces
{
    public interface IAccountService
    {
        Task<Account> GetAccountByIdAsync(string id);
        Task<Account> CreateNewAccountAsync(string id, float balance);
        Task<int> SaveChangesAsync();
    }
}
