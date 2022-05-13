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
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            //InitializeComponent();
            Title = "Jaanuar";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Jaanuar on Gregoriuse kalendris aasta esimene kuu. Jaanuar oli Vana-Roomas aastani 154 eKr aasta eelviimane ehk üheteistkümnes kuu. " +
                "Jaanuaris on 31 päeva." +
                "Ladinakeelne nimetus januarius on jaanuarile antud kahenäolise jumala Januse järgi, keda arvati mõjutavat kõiki töid ja nende alustamist.    "



            };
            Image img = new Image()
            {
                Source = new Uri("https://upload.wikimedia.org/wikipedia/commons/a/a7/Niitv%C3%A4lja_raba_jaanuar_2014_HDR.jpg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}