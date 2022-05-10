using System.ComponentModel;
using TabbedPage.ViewModels;
using Xamarin.Forms;

namespace TabbedPage.Views
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