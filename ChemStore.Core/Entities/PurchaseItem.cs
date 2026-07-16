namespace ChemStore.Core.Entities;

public class PurchaseItem : BaseEntity
{
    public int PurchaseId { get; set; }

    public Purchase Purchase { get; set; } = null!;

    public int ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Total { get; set; }
}
public int? BatchId { get; set; }

public Batch? Batch { get; set; }
