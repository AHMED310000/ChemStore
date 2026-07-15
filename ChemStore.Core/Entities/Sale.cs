namespace ChemStore.Core.Entities;

public class Sale : BaseEntity
{
    public string InvoiceNo { get; set; } = string.Empty;

    public DateTime InvoiceDate { get; set; } = DateTime.Now;

    public int? CustomerId { get; set; }

    public Customer? Customer { get; set; }

    public decimal Total { get; set; }

    public decimal Discount { get; set; }

    public decimal Net { get; set; }

    public bool IsCash { get; set; }

    public ICollection<SaleItem> Items { get; set; }
        = new List<SaleItem>();
}
