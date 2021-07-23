using Bank.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Bank.Repositories
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly BankContext _context;

        public DatabaseManager(BankContext context)
        {
            _context = context;
        }

        public Task<bool> DropDatabaseAsync()
        {
            return _context.Database.EnsureDeletedAsync();
        }
    }
}
