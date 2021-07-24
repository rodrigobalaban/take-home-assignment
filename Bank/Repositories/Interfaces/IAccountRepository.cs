using Bank.Models;
using System.Threading.Tasks;

namespace Bank.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account> GetAccountById(string id);
        Task<Account> SaveNewAccountAsync(Account account);
        Task<Account> SaveChangesAsync(Account account);
    }
}
