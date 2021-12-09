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



        private async void btnStartLogin(object sender, EventArgs e)
        {
            await DisplayAlert("RankStudent", "Ingreso fallido para el usuario:\n"+RS_Login_User.Text, "Cancelar");
        }
    }
}
