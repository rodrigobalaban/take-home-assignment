using System.Threading.Tasks;

namespace Bank.Repositories.Interfaces
{
    public interface IDatabaseManager
    {
        Task<bool> DropDatabaseAsync();
    }
}
