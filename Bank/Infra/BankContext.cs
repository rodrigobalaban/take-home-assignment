using Bank.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank.Infra
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
