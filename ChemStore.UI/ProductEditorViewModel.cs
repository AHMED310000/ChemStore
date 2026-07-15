using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ChemStore.Core.Entities;

namespace ChemStore.UI.ViewModels;

public partial class ProductEditorViewModel : ObservableObject
{
    [ObservableProperty]
    private Product product = new();

    [ObservableProperty]
    private bool isEditMode;

    [RelayCommand]
    private void Save()
    {
        // سيتم ربطها بقاعدة البيانات
    }

    [RelayCommand]
    private void Cancel()
    {
    }
}
