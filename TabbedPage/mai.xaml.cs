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
    public partial class mai : ContentPage
    {
        public mai()
        {
            InitializeComponent();
            Title = "Mai";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Mai ehk lehekuu on Gregoriuse kalendris aasta viies kuu. Selles on 31 päeva. " +
                "Mai oli Vana-Roomas aastani 154 eKr aasta kolmas kuu. Nimetus tuleb ladinakeelsest nimetusest Maius, mis oli antud kas jumalatar Maia või kasvujumal Maiuse järgi. "



            };
            Image img = new Image()
            {
                Source = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Eesti_loodus_%28T%C3%BCrisalu%29.jpeg/1200px-Eesti_loodus_%28T%C3%BCrisalu%29.jpeg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}