using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitcoinMixer.Models
{
    public class MixTransaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime ScheduledSendTime { get; set; }

        [ForeignKey("Deposit")]
        public int DepositId { get; set; }

        public Deposit Deposit { get; set; }
    }
}