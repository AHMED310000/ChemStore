namespace ChemStore.Core.Entities;

public class Company : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Notes { get; set; }

    public ICollection<Product> Products { get; set; }
        = new List<Product>();
}
