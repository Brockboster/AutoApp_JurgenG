using System;
using System.Collections.Generic;
using System.ComponentModel;
using AutoApp_JurgenG.Models;
using AutoApp_JurgenG.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoApp_JurgenG.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}