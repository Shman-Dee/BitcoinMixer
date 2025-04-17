using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitcoinMixer.Models
{
    public class Withdrawal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string WithdrawalAddress { get; set; } = string.Empty;

        [Required]
        [Range(0.00000001, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public string Status { get; set; } = "pending"; // pending, completed

        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    }
}