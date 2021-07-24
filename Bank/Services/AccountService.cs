using Bank.Models;
using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepositoy)
        {
            _accountRepository = accountRepositoy;
        }

        public async Task<Account> CreateNewAccountAsync(string id, float balance)
        {
            var account = new Account
            {
                Id = id,
                Balance = balance
            };

            return await _accountRepository.SaveNewAccountAsync(account);
        }

        public async Task<Account> GetAccountByIdAsync(string id)
        {
            return await _accountRepository.GetAccountById(id);
        }

        public async Task<Account> UpdateAccountAsync(Account account)
        {
            return await _accountRepository.SaveChangesAsync(account);
        }
    }
}
