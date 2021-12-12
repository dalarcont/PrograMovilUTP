using DA_Unidad2.View;
using DA_Unidad2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DA_Unidad2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }


        //Run signup
        private async void btnStartSignup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewUser());
        }
    }
}
