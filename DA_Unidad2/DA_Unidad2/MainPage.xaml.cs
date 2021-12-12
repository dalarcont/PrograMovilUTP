using DA_Unidad2.View;
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
        }


        //Let login
        private async void btnStartLogin(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(RS_Login_User.Text)) || (string.IsNullOrEmpty(RS_Login_Pkey.Text))){
                await DisplayAlert("RankStudent", "Faltan datos para el acceso", "Cancelar");
            }
            else
            {
                await DisplayAlert("RankStudent", "Ingreso fallido para el usuario:\n" + RS_Login_User.Text + "\nContraseña:" + RS_Login_Pkey.Text, "Cancelar");
            }
        }

        //Run signup
        private async void btnStartSignup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewUser());
        }
    }
}
