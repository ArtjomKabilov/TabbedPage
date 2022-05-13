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
    public partial class Marts : ContentPage
    {
        public Marts()
        {
            InitializeComponent();
            Title = "Märts";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Märts on Gregoriuse kalendris aasta kolmas kuu. Selles on 31 päeva." +
                "Märts on tuletatud nimetusest Martius, mis roomlaste kalendris tähendas sõjajumal Marsile pühendatud kuud. Märts oli Vana-Roomas aastani 154 eKr aasta esimene kuu. " +
                "Martius oli muistsetel roomlastel aasta hakatus, kevadkuu, aeg põllutöid alustada. Mars oli tegelikult etruskide," +
                "põllu- ja karjajumal. Roomlased võtsid ta etruskidelt üle (nagu palju muudki, ka nonde sõjakunsti) ja tegid tast endale verejanulise sõjajumala, nagu seda oli kreeklaste Ares. Kevadkuu nimetus jäi endiseks. "


            };
            Image img = new Image()
            {
                Source = new Uri("https://mentoritekoda.ee/wp-content/uploads/2018/10/spring-720x380.jpg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}