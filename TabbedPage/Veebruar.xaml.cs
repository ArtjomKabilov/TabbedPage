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
    public partial class Veebruar : ContentPage
    {
        public Veebruar()
        {
            InitializeComponent();
            Title = "Veebruar";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Veebruar on Juliuse kalendris ja Gregoriuse kalendris aasta teine kuu, samuti aasta kõige lühem kuu. Selles on lihtaastal 28 päeva ja liigaastal 29 päeva. " +
                "Nimetus 'veebruar' on üle võetud roomlaste kalendrist, kus Februarius tähendas puhastuskuud; Februa oli puhastusjumal ning tähendas ka puhastus- ja lepituspüha. Veebruar oli Vana-Roomas aastani 154 eKr aasta viimane, kaheteistkümnes kuu. "
            };
            Image img = new Image()
            {
                Source = new Uri("https://www.vorumaateataja.ee/images/2020/02veebruar/talv.jpg")
            };
            
            this.Content = new StackLayout{ Children = { lb,img } };

        }
    }
}