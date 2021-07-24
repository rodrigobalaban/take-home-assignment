using Bank.Models;
using Bank.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Bank.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        public async Task<Account> GetAccountById(string id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task<Account> SaveNewAccountAsync(Account account)
        {
            await _context.AddAsync(account);
            return await SaveChangesAsync(account);
        }

        public async Task<Account> SaveChangesAsync(Account account)
        {
            await _context.SaveChangesAsync();
            return account;
        }
    }
}
