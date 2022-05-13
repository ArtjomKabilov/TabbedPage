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
    public partial class September : ContentPage
    {
        public September()
        {
            InitializeComponent();
            Title = "September";
            Label lb = new Label()
            {
                TextColor = Color.Black,
                Text = "Septembris on 30 päeva. " +
               "Sõna 'september' on tulnud ladina sõnast septem ('seitse'). See oli Rooma kalendri seitsmes kuu (see kalender algas märtsikuuga). "
            };
            Image img = new Image()
            {
                Source = new Uri("https://t4.ftcdn.net/jpg/02/06/20/03/360_F_206200339_N9VJVoy0VvbbhRgGLIOHyJUJRJyxAmyO.jpg")
            };

            this.Content = new StackLayout { Children = { lb, img } };
        }
    }
}