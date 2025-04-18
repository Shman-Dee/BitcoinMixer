namespace BitcoinMixer.DTOs
{
    public class DepositReadDto
    {
        public int Id { get; set; }
        public string FakeBitcoinAddress { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Status { get; set; } = "pending";
    }
}