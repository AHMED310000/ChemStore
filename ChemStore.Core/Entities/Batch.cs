namespace ChemStore.Core.Entities;

public class Batch : BaseEntity
{
    public int ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public string BatchNo { get; set; } = string.Empty;

    public DateTime? ProductionDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal Quantity { get; set; }

    public decimal Cost { get; set; }
}
