namespace ChemStore.Core.Entities;

public class Product : BaseEntity
{
    public string Code { get; set; } = string.Empty;

    public string? Barcode { get; set; }

    public string Name { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;

    public int UnitId { get; set; }

    public Unit Unit { get; set; } = null!;

    public decimal PurchasePrice { get; set; }

    public decimal AverageCost { get; set; }

    public decimal RetailPrice { get; set; }

    public decimal HalfWholesalePrice { get; set; }

    public decimal WholesalePrice { get; set; }

    public decimal MinimumStock { get; set; }

    public bool IsActive { get; set; } = true;

    public string? Notes { get; set; }

    public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        = new List<InventoryTransaction>();
}
