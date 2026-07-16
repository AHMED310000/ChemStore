using ChemStore.Core.Entities;
using ChemStore.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChemStore.UI.ViewModels;

public partial class ProductEditorViewModel : ObservableObject
{
    private readonly IProductService _productService;

    [ObservableProperty]
    private Product product = new();

    [ObservableProperty]
    private bool isEditMode;

    public ProductEditorViewModel(IProductService productService)
    {
        _productService = productService;
    }

    [RelayCommand]
    private async Task SaveAsync()
    {
        if (IsEditMode)
            await _productService.UpdateAsync(Product);
        else
            await _productService.AddAsync(Product);

        CloseRequested?.Invoke(this, EventArgs.Empty);
    }

    [RelayCommand]
    private void Cancel()
    {
        CloseRequested?.Invoke(this, EventArgs.Empty);
    }

    public event EventHandler? CloseRequested;
}
