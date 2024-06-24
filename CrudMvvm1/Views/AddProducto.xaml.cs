using CrudMvvm1.Models;
using CrudMvvm1.ViewModels;

namespace CrudMvvm1.Views;

public partial class AddProducto : ContentPage
{
    private AddProductoViewModel viewModel;
    public AddProducto()
    {
        InitializeComponent();
        viewModel = new AddProductoViewModel();
        BindingContext = viewModel;
    }

    public AddProducto(Producto producto)
    {
        InitializeComponent();
        viewModel = new AddProductoViewModel(producto);
        BindingContext = viewModel;
    }
}