using Bank.Repositories.Interfaces;
using Bank.Services.Interfaces;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class ResetService : IResetService
    {
        private readonly IDatabaseManager _databaseManager;

        public ResetService(IDatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public Task<bool> ResetAsync()
        {
            return _databaseManager.DropDatabaseAsync();
        }
    }
}
