using ChemStore.Core.Entities;
using ChemStore.Data.Repositories;
using ChemStore.Services.Interfaces;

namespace ChemStore.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IGenericRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task AddAsync(Product product)
    {
        await _repository.AddAsync(product);
        await _repository.SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        await _repository.UpdateAsync(product);
        await _repository.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _repository.GetByIdAsync(id);

        if (product == null)
            return;

        await _repository.DeleteAsync(product);
        await _repository.SaveChangesAsync();
    }

   public async Task<IEnumerable<Product>> SearchAsync(string keyword)
{
    return await _repository.SearchAsync(keyword);
}
        keyword = keyword.ToLower();

        return await _repository.FindAsync(x =>
            x.Name.ToLower().Contains(keyword) ||
            x.Code.ToLower().Contains(keyword) ||
            (x.Barcode ?? "").Contains(keyword));
    }
}
public decimal ReorderLevel { get; set; }

public decimal MaximumStock { get; set; }

public string? Manufacturer { get; set; }

public string? Brand { get; set; }

public string? ActiveIngredient { get; set; }

public string? PackageSize { get; set; }
