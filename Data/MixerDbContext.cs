using Microsoft.EntityFrameworkCore;
using BitcoinMixer.Models;

namespace BitcoinMixer.Data
{
    public class MixerDbContext : DbContext
    {
        public MixerDbContext(DbContextOptions<MixerDbContext> options) : base(options) { }

        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<MixTransaction> MixTransactions { get; set; }
        public DbSet<Withdrawal> Withdrawals { get; set; }
    }
}