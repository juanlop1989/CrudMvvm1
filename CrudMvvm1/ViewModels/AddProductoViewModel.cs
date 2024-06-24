using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CrudMvvm1.Models;
using CrudMvvm1.Services;


namespace CrudMvvm1.ViewModels
{
    public partial class AddProductoViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private string proveedor;

        [ObservableProperty]
        private double precio_compra;

        [ObservableProperty]
        private double total;

        private readonly ProductoService service;

        public AddProductoViewModel()
        {
            service = new ProductoService();
        }

        public AddProductoViewModel(Producto producto)
        {
            Id = producto.Id;
            Nombre = producto.Nombre;
            Proveedor = producto.Proveedor;
            Precio_compra = producto.Precio_compra;
            Total = producto.Total;
            service = new ProductoService();
        }

        private void Alerta(String Titulo, String Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private async Task AddUpdate()
        {
            try
            {
                Producto producto = new Producto
                {
                    Id = Id,
                    Nombre = Nombre,
                    Proveedor = Proveedor,
                    Precio_compra = Precio_compra,
                    Total = Total,
                };

                if (producto.Nombre != null || producto.Nombre != "")
                {
                    if (Id == 0)
                    {
                        service.Insert(producto);
                    }
                    else
                    {
                        service.Update(producto);
                    }
                    await App.Current!.MainPage!.Navigation.PopAsync();
                }
                else
                {
                    Alerta("ADVERTENCIA", "Ingrese el nombre completo");
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }
    }
}
