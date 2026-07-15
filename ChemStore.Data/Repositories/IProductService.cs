using ChemStore.Core.Entities;

namespace ChemStore.Services.Interfaces;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();

    Task<Product?> GetByIdAsync(int id);

    Task AddAsync(Product product);

    Task UpdateAsync(Product product);

    Task DeleteAsync(int id);

    Task<IEnumerable<Product>> SearchAsync(string keyword);
}
