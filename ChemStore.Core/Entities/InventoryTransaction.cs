namespace ChemStore.Core.Entities;

public class InventoryTransaction : BaseEntity
{
    public int ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public DateTime TransactionDate { get; set; } = DateTime.Now;

    // Purchase, Sale, ReturnIn, ReturnOut, Adjustment, OpeningBalance
    public string TransactionType { get; set; } = string.Empty;

    public decimal Quantity { get; set; }

    public decimal UnitCost { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Notes { get; set; }
}
