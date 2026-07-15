namespace ChemStore.Core.Entities;

public class Expense : BaseEntity
{
    public DateTime ExpenseDate { get; set; } = DateTime.Now;

    public string ExpenseType { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public string? Notes { get; set; }
}
