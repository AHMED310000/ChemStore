namespace ChemStore.Core.Entities;

public class Purchase : BaseEntity
{
    public string InvoiceNo { get; set; } = string.Empty;

    public DateTime InvoiceDate { get; set; } = DateTime.Now;

    public int SupplierId { get; set; }

    public Supplier Supplier { get; set; } = null!;

    public decimal Total { get; set; }

    public ICollection<PurchaseItem> Items { get; set; }
        = new List<PurchaseItem>();
}
