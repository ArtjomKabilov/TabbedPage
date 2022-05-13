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
    public partial class Detsember : ContentPage
    {
        public Detsember()
        {
            InitializeComponent();
            Title = "Detsember";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Detsember ehk jõulukuu ehk talvistepühakuu ehk talvekuu on Gregoriuse kalendris aasta kaheteistkümnes kuu. Detsembris on 31 päeva.  " +
               "Detsembrit nimetatakse ka nimetustega talvistekuu, talsipühakuu, mängukuu (jõulumängude aja järgi)."



            };
            Image img = new Image()
            {
                Source = new Uri("https://api.delfi.ee/media-api-image-cropper/v1/f5a03e30-b8f5-11eb-a43e-c39d2a6aaf33.jpg?w=1200&h=711")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}