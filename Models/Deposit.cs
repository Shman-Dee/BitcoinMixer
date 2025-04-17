using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitcoinMixer.Models
{
    public class Deposit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FakeBitcoinAddress { get; set; } = string.Empty;

        [Required]
        [Range(0.00000001, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public string Status { get; set; } = "pending"; // pending, confirmed, mixed

        public List<MixTransaction> MixTransactions { get; set; } = new();
    }
}