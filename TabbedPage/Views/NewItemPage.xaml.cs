using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabbedPage.Models;
using TabbedPage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPage.Views
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