using Bank.Models;
using Bank.Repositories;
using Bank.Services.Interfaces;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AccountService : IAccountService
    {
        private readonly BankContext _context;

        public AccountService(BankContext context)
        {
            _context = context;
        }

        public async Task<Account> CreateNewAccountAsync(string id, float balance)
        {
            var account = new Account(id, balance);

            await _context.AddAsync(account);
            await SaveChangesAsync();

            return account;
        }

        public async Task<Account> GetAccountByIdAsync(string id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
