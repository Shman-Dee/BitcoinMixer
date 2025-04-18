using BitcoinMixer.Data;
using BitcoinMixer.Models;
using Microsoft.EntityFrameworkCore;

namespace BitcoinMixer.Repositories
{
    public class DepositRepository : IDepositRepository
    {
        private readonly MixerDbContext _context;

        public DepositRepository(MixerDbContext context)
        {
            _context = context;
        }

        public async Task<Deposit> CreateDepositAsync(Deposit deposit)
        {
            _context.Deposits.Add(deposit);
            await _context.SaveChangesAsync();
            return deposit;
        }

        public async Task<Deposit?> GetDepositByIdAsync(int id)
        {
            return await _context.Deposits
                                 .Include(d => d.MixTransactions) // Optional: Include MixTransactions when fetching
                                 .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<Deposit>> GetAllDepositsAsync()
        {
            return await _context.Deposits.ToListAsync();
        }

        public async Task UpdateDepositStatusAsync(int depositId, string newStatus)
        {
            var deposit = await _context.Deposits.FindAsync(depositId);
            if (deposit != null)
            {
                deposit.Status = newStatus;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteDepositAsync(int id)
        {
            var deposit = await _context.Deposits.FindAsync(id);
            if (deposit != null)
            {
                _context.Deposits.Remove(deposit);
                await _context.SaveChangesAsync();
            }
        }
    }
}