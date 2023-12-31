namespace Domain.Objects.DTO
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int? FromToAccountId { get; set; } = null;
        public string Type { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0m;
        public decimal Fees { get; set; } = 0m;
    }
}
