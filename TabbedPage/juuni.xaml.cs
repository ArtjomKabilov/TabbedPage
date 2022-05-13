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
    public partial class juuni : ContentPage
    {
        public juuni()
        {
            InitializeComponent();
            Title = "Juuni";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Juuni on Gregoriuse kalendris aasta kuues kuu. Selles on 30 päeva.  "



            };
            Image img = new Image()
            {
                Source = new Uri("https://1.bp.blogspot.com/-sIS2szFhekw/YNhFlF7CaOI/AAAAAAAAcIY/2nn3NwtlypcJzgJFj-UWBebGouSO-f8aQCLcBGAsYHQ/s1350/photo-1598711000301-de3eade4365f.webp")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}