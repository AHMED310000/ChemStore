public class Product : BaseEntity
{
    public string Code { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string? Barcode { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public int? CompanyId { get; set; }
    public Company? Company { get; set; }

    public bool IsActive { get; set; } = true;

    public string? Notes { get; set; }

    public ICollection<ProductUnit> Units { get; set; } = new List<ProductUnit>();

    public ICollection<Batch> Batches { get; set; } = new List<Batch>();
}

public bool AllowNegativeStock { get; set; }

public bool TrackExpiryDate { get; set; }

public bool TrackBatch { get; set; }
