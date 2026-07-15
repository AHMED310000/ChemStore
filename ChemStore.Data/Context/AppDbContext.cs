using ChemStore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChemStore.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductUnit> ProductUnits => Set<ProductUnit>();
    public DbSet<ProductPrice> ProductPrices => Set<ProductPrice>();

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Unit> Units => Set<Unit>();

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Supplier> Suppliers => Set<Supplier>();

    public DbSet<Sale> Sales => Set<Sale>();
    public DbSet<SaleItem> SaleItems => Set<SaleItem>();

    public DbSet<Purchase> Purchases => Set<Purchase>();
    public DbSet<PurchaseItem> PurchaseItems => Set<PurchaseItem>();

    public DbSet<Warehouse> Warehouses => Set<Warehouse>();

    public DbSet<StockBalance> StockBalances => Set<StockBalance>();

    public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();

    public DbSet<TreasuryTransaction> TreasuryTransactions => Set<TreasuryTransaction>();

    public DbSet<CustomerPayment> CustomerPayments => Set<CustomerPayment>();

    public DbSet<SupplierPayment> SupplierPayments => Set<SupplierPayment>();

    public DbSet<Expense> Expenses => Set<Expense>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasIndex(x => x.Code)
            .IsUnique();

        modelBuilder.Entity<Product>()
            .HasIndex(x => x.Barcode);

        modelBuilder.Entity<Product>()
            .Property(x => x.Name)
            .HasMaxLength(250);

        modelBuilder.Entity<Customer>()
            .Property(x => x.Name)
            .HasMaxLength(200);

        modelBuilder.Entity<Supplier>()
            .Property(x => x.Name)
            .HasMaxLength(200);

        modelBuilder.Entity<Warehouse>()
            .HasIndex(x => x.Code)
            .IsUnique();
    }
}
