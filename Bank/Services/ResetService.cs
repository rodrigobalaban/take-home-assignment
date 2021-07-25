using Bank.Repositories;
using Bank.Services.Interfaces;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class ResetService : IResetService
    {
        private readonly BankContext _context;

        public ResetService(BankContext context)
        {
            _context = context;
        }

        public Task<bool> ResetAsync()
        {
            return _context.Database.EnsureDeletedAsync();
        }
    }
}
