using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
            Title = "November";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "November ehk kooljakuu ehk talvekuu ehk hingekuu on Gregoriuse kalendris aasta üheteistkümnes kuu. Selles on 30 päeva.   "
               
            };
            Image img = new Image()
            {
                Source = new Uri("https://thumbs.dreamstime.com/b/autumn-foliage-november-header-white-background-autumn-foliage-white-background-text-november-102402967.jpg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}