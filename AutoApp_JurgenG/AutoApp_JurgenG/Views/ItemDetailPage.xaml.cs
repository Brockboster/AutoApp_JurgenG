using System.ComponentModel;
using AutoApp_JurgenG.ViewModels;
using Xamarin.Forms;

namespace AutoApp_JurgenG.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}