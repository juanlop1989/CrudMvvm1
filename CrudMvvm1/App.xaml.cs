﻿using CrudMvvm1.Views;
namespace CrudMvvm1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ProductoMain());
        }
    }
}