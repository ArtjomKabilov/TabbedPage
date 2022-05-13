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
    public partial class Oktoober : ContentPage
    {
        public Oktoober()
        {
            InitializeComponent();
            Title = "Oktoober";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Oktoober ehk rehekuu ehk viinakuu on Gregoriuse kalendris aasta kümnes kuu. Selles on 31 päeva.  " +
               "Oktoobri rahvapärased nimetused on ka kooljakuu, hingekuu, kosjakuu, kolletamiskuu, lehelanguskuu ehk lehevarisemiskuu, porikuu, roojakuu, orjakuu (teotööliste öise rehepeksuaja järgi), sügisekuu, simunakuu. "
            };
            Image img = new Image()
            {
                Source = new Uri("https://100woerter.de/wp-content/uploads/2019/04/Oktober-Herkunft-des-Names-des-Monats.jpg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}