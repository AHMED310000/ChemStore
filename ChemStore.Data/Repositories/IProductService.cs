using ChemStore.Core.Entities;

namespace ChemStore.Data.Repositories;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IEnumerable<Product>> SearchAsync(string keyword);

    Task<IEnumerable<Product>> GetLowStockProductsAsync();

    Task<Product?> GetByCodeAsync(string code);

    Task<Product?> GetByBarcodeAsync(string barcode);
}
