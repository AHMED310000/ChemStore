using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChemStore.UI.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private object? currentView;

    [RelayCommand]
    private void Dashboard()
    {
        CurrentView = new DashboardView();
    }

    [RelayCommand]
    private void Products()
    {
        CurrentView = new ProductsView();
    }

    [RelayCommand]
    private void Customers()
    {
        CurrentView = new CustomersView();
    }

    [RelayCommand]
    private void Suppliers()
    {
        CurrentView = new SuppliersView();
    }

    [RelayCommand]
    private void Sales()
    {
        CurrentView = new SalesView();
    }

    [RelayCommand]
    private void Purchases()
    {
        CurrentView = new PurchasesView();
    }

    [RelayCommand]
    private void Treasury()
    {
        CurrentView = new TreasuryView();
    }

    [RelayCommand]
    private void Reports()
    {
        CurrentView = new ReportsView();
    }

    [RelayCommand]
    private void Settings()
    {
        CurrentView = new SettingsView();
    }
}
