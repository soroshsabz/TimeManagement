using MauiClientApp.Models;
using MauiClientApp.PageModels;

namespace MauiClientApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}