
using CrudMvvm1.ViewModels;

namespace CrudMvvm1.Views;

public partial class ProductoMain : ContentPage
{
    private ProductoMainViewModel viewModel;
    public ProductoMain()
    {
        InitializeComponent();
        viewModel = new ProductoMainViewModel();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.GetAll();
    }
}
