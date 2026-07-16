public static class ProductValidator
{
    public static void Validate(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name))
            throw new Exception("اسم الصنف مطلوب");

        if (string.IsNullOrWhiteSpace(product.Code))
            throw new Exception("كود الصنف مطلوب");
    }
}
