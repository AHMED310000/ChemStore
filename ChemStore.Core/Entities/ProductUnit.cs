namespace ChemStore.Core.Entities;

public class ProductUnit : BaseEntity
{
    public int ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public string UnitName { get; set; } = string.Empty;

    // عدد الوحدات الأساسية داخل هذه الوحدة
    public decimal ConversionFactor { get; set; }

    public decimal PurchasePrice { get; set; }

    public decimal RetailPrice { get; set; }

    public decimal HalfWholesalePrice { get; set; }

    public decimal WholesalePrice { get; set; }

    public bool IsDefaultPurchaseUnit { get; set; }

    public bool IsDefaultSalesUnit { get; set; }

    public string? Barcode { get; set; }
}
