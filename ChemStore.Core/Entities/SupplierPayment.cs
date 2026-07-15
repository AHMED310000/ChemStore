namespace ChemStore.Core.Entities;

public class SupplierPayment : BaseEntity
{
    public int SupplierId { get; set; }

    public Supplier Supplier { get; set; } = null!;

    public DateTime PaymentDate { get; set; } = DateTime.Now;

    public decimal Amount { get; set; }

    public string? Notes { get; set; }
}
