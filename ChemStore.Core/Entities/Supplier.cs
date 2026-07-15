namespace ChemStore.Core.Entities;

public class Supplier : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public decimal Balance { get; set; }

    public string? Notes { get; set; }

    public ICollection<Purchase> Purchases { get; set; }
        = new List<Purchase>();

    public ICollection<SupplierPayment> Payments { get; set; }
        = new List<SupplierPayment>();
}
