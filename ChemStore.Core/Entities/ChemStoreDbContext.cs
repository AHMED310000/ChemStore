using ChemStore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChemStore.Data.Context;

public class ChemStoreDbContext : DbContext
{
    public ChemStoreDbContext(DbContextOptions<ChemStoreDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Unit> Units => Set<Unit>();

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Supplier> Suppliers => Set<Supplier>();

    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<SaleItem> SaleItems => Set<SaleItem>();

    public DbSet<Purchase> Purchases => Set<Purchase>();
    public DbSet<PurchaseItem> PurchaseItems => Set<PurchaseItem>();

    public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();

    public DbSet<TreasuryTransaction> TreasuryTransactions => Set<TreasuryTransaction>();

    public DbSet<Expense> Expenses => Set<Expense>();

    public DbSet<CustomerPayment> CustomerPayments => Set<CustomerPayment>();

    public DbSet<SupplierPayment> SupplierPayments => Set<SupplierPayment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasIndex(x => x.Code)
            .IsUnique();

        modelBuilder.Entity<Product>()
            .HasIndex(x => x.Barcode);

        modelBuilder.Entity<Category>()
            .HasIndex(x => x.Name);

        modelBuilder.Entity<Unit>()
            .HasIndex(x => x.Name);

        modelBuilder.Entity<Customer>()
            .HasIndex(x => x.Name);

        modelBuilder.Entity<Supplier>()
            .HasIndex(x => x.Name);

        modelBuilder.Entity<Sale>()
            .HasIndex(x => x.InvoiceNo)
            .IsUnique();

        modelBuilder.Entity<Purchase>()
            .HasIndex(x => x.InvoiceNo)
            .IsUnique();
    }
}
