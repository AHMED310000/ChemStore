namespace ChemStore.Core.Entities;

public class StockBalance : BaseEntity
{
    public int ProductId { get; set; }

    public int ProductUnitId { get; set; }

    public int WarehouseId { get; set; }

    public decimal Quantity { get; set; }

    public decimal AverageCost { get; set; }
}
