using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarinExample.Views;

namespace xamarinExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Hello(object sender, EventArgs e)
        {
            DisplayAlert("Disponible pronto","No es posible acceder en el momento.","Ok");
        }
        
    }
}
