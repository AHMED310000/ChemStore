using ChemStore.Core.Entities;
using ChemStore.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ChemStore.Data.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly ChemStoreDbContext _context;

    public ProductRepository(ChemStoreDbContext context)
        : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> SearchAsync(string keyword)
    {
        keyword = keyword.Trim().ToLower();

        return await _context.Products
            .Include(x => x.Category)
            .Include(x => x.Unit)
            .Where(x =>
                x.Name.ToLower().Contains(keyword) ||
                x.Code.ToLower().Contains(keyword) ||
                (x.Barcode ?? "").Contains(keyword))
            .OrderBy(x => x.Name)
            .ToListAsync();
    }

    public async Task<Product?> GetByCodeAsync(string code)
    {
        return await _context.Products
            .FirstOrDefaultAsync(x => x.Code == code);
    }

    public async Task<Product?> GetByBarcodeAsync(string barcode)
    {
        return await _context.Products
            .FirstOrDefaultAsync(x => x.Barcode == barcode);
    }

    public async Task<IEnumerable<Product>> GetLowStockProductsAsync()
    {
        return await _context.Products
            .Where(x => x.IsActive)
            .OrderBy(x => x.Name)
            .ToListAsync();
    }
}
public override async Task<List<Product>> GetAllAsync()
{
    return await _context.Products
        .Include(x => x.Category)
        .Include(x => x.Company)
        .Where(x => !x.IsDeleted)
        .OrderBy(x => x.Name)
        .ToListAsync();
}
