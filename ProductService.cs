using ChemStore.Core.Entities;
using ChemStore.Data;
using Microsoft.EntityFrameworkCore;
namespace ChemStore.Services;
public class ProductService(AppDbContext db)
{
    public Task<List<Product>> GetAllAsync() => db.Products.Where(x => !x.IsDeleted).OrderBy(x => x.Name).ToListAsync();
    public async Task AddAsync(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Code)) throw new ArgumentException("كود الصنف مطلوب");
        if (string.IsNullOrWhiteSpace(product.Name)) throw new ArgumentException("اسم الصنف مطلوب");
        db.Products.Add(product);
        await db.SaveChangesAsync();
    }
}