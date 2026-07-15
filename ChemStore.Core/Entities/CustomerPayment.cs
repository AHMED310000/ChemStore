namespace ChemStore.Core.Entities;

public class CustomerPayment : BaseEntity
{
    public int CustomerId { get; set; }

    public Customer Customer { get; set; } = null!;

    public DateTime PaymentDate { get; set; } = DateTime.Now;

    public decimal Amount { get; set; }

    public string? Notes { get; set; }
}
