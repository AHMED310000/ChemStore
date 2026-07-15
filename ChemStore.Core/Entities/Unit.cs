namespace ChemStore.Core.Entities;

public class Unit : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Symbol { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
