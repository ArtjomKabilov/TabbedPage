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
    public partial class aprill : ContentPage
    {
        public aprill()
        {
            InitializeComponent();
            Title = "Aprill";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Aprill on Gregoriuse kalendris aasta neljas kuu. Selles on 30 päeva. " +
             "Aprill oli Vana-Roomas aastani 154 eKr aasta teine kuu. Nimetus tuleb ladinakeelsest nimetusest Aprilis ja tähendab arvatavasti 'avav'. " +
             "Aprill, mai ja juuni tähendasid (vist etruskidelt laenatuna) ka idanemist, kasvamist ja noorust.  "



            };
            Image img = new Image()
            {
                Source = new Uri("https://p.ocdn.ee/53/i/2015/4/10/rtr55uvo.ttj.jpg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}