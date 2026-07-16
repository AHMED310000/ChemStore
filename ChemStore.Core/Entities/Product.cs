namespace ChemStore.Core.Entities;

public class Product : BaseEntity
{
    public string Code { get; set; } = string.Empty;

    public string? Barcode { get; set; }

    public string Name { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;

  public ICollection<ProductUnit> Units { get; set; }
    = new List<ProductUnit>();

    public decimal AverageCost { get; set; }

    public decimal MinimumStock { get; set; }

    public bool IsActive { get; set; } = true;

    public string? Notes { get; set; }

    public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        = new List<InventoryTransaction>();
}
public int? CompanyId { get; set; }

public Company? Company { get; set; }

public string? ScientificName { get; set; }

public string? RegistrationNo { get; set; }

public decimal VatRate { get; set; }

public bool AllowNegativeStock { get; set; }

public bool TrackExpiryDate { get; set; }

public bool TrackBatch { get; set; }
