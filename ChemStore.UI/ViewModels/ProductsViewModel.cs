using ChemStore.Core.Entities;
using ChemStore.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChemStore.UI.ViewModels;

public partial class ProductsViewModel : ObservableObject
{
    private readonly IProductService _productService;

    public ObservableCollection<Product> Products { get; }
        = new();

    [ObservableProperty]
    private string searchText = string.Empty;

    public ProductsViewModel(IProductService productService)
    {
        _productService = productService;
    }

    [RelayCommand]
    public async Task LoadAsync()
    {
        Products.Clear();

        var items = await _productService.GetAllAsync();

        foreach (var item in items)
            Products.Add(item);
    }

    partial void OnSearchTextChanged(string value)
    {
        _ = SearchAsync(value);
    }

    private async Task SearchAsync(string keyword)
    {
        Products.Clear();

        var items = string.IsNullOrWhiteSpace(keyword)
            ? await _productService.GetAllAsync()
            : await _productService.SearchAsync(keyword);

        foreach (var item in items)
            Products.Add(item);
    }
}
