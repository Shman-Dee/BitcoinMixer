using System.ComponentModel.DataAnnotations;

namespace BitcoinMixer.DTOs
{
    public class DepositCreateDto
    {
        [Required]
        public string FakeBitcoinAddress { get; set; } = string.Empty;

        [Required]
        [Range(0.00000001, double.MaxValue)]
        public decimal Amount { get; set; }
    }
}