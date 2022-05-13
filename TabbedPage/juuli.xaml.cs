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
    public partial class juuli : ContentPage
    {
        public juuli()
        {
            InitializeComponent();
            Title = "Juuli";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Juuli ehk heinakuu on Gregoriuse kalendris aasta seitsmes kuu. Selles on 31 päeva.   "



            };
            Image img = new Image()
            {
                Source = new Uri("https://p.ocdn.ee/53/i/2021/6/25/0au3b0ws.elr.jpg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}