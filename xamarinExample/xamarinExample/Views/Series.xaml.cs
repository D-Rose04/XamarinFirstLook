using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Series : ContentPage
    {
        public Series()
        {
            InitializeComponent();
        }
        private void Hello(object sender, EventArgs e)
        {
            DisplayAlert("Disponible pronto", "No es posible acceder en el momento.", "Ok");
        }
    }
}