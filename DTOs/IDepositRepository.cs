using BitcoinMixer.Models;

namespace BitcoinMixer.Repositories
{
    public interface IDepositRepository
    {
        Task<Deposit> CreateDepositAsync(Deposit deposit);
        Task<Deposit?> GetDepositByIdAsync(int id);
        Task<IEnumerable<Deposit>> GetAllDepositsAsync();
        Task UpdateDepositStatusAsync(int depositId, string newStatus);
        Task DeleteDepositAsync(int id);
    }
}