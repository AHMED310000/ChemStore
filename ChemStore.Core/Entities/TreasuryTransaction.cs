namespace ChemStore.Core.Entities;

public class TreasuryTransaction : BaseEntity
{
    public DateTime TransactionDate { get; set; } = DateTime.Now;

    // In / Out
    public string TransactionType { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public string Description { get; set; } = string.Empty;

    public string? ReferenceNo { get; set; }
}
