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
    public partial class august : ContentPage
    {
        public august()
        {
            InitializeComponent();
            Title = "August";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "August ehk lõikuskuu on Gregoriuse kalendris aasta kaheksas kuu. Selles on 31 päeva.   " +
              "Augusti rahvapärased nimetused on ka põimukuu, viljakuu, rukkikuu, mädakuu ehk mädanemiskuu, hallituskuu, kirbukuu ja pärtlikuu." +
              "August oli Rooma kalendri kuues kuu (kuni aastani 154 eKr) ning kandis seetõttu nimetust sextilis seni, kuni 8 eKr otsustas senat selle kuu ümber nimetada keiser Augustuse auks. "



            };
            Image img = new Image()
            {
                Source = new Uri("https://c.tadst.com/gfx/1200x630/8-august-poppy.jpg?1")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}