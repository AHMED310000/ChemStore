Task AddAsync(Product product);

Task UpdateAsync(Product product);

Task DeleteAsync(int id);

Task<Product?> GetByIdAsync(int id);

Task<List<Product>> GetAllAsync();

Task<List<Product>> SearchAsync(string keyword);
