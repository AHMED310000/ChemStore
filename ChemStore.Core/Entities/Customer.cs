namespace ChemStore.Core.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public decimal Balance { get; set; }

    public string? Notes { get; set; }

    public ICollection<Sale> Sales { get; set; }
        = new List<Sale>();

    public ICollection<CustomerPayment> Payments { get; set; }
        = new List<CustomerPayment>();
}
