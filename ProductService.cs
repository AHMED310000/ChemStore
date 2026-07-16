public async Task AddAsync(Product product)
{
    if (string.IsNullOrWhiteSpace(product.Name))
        throw new Exception("اسم الصنف مطلوب.");

    if (string.IsNullOrWhiteSpace(product.Code))
        throw new Exception("كود الصنف مطلوب.");

    var exists = await _repository.GetByCodeAsync(product.Code);

    if (exists != null)
        throw new Exception("الكود مستخدم بالفعل.");

    await _repository.AddAsync(product);

    await _repository.SaveChangesAsync();
}
