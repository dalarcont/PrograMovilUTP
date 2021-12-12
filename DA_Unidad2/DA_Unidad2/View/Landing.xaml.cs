using DA_Unidad2.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DA_Unidad2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Landing : TabbedPage
    {

        public Landing(string usr, string pkey)
        {
            InitializeComponent();
            BindingContext = new UserLogedViewModel(usr, pkey);
        }

        //Run signup
        private async void btnExit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void btnYes(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("RankStudent", "Estableciste buena calificación a tu compañero\nRecuerda que puedes cambiar de opinión.","OK");
        }

        private void btnNo(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("RankStudent", "Estableciste mala calificación a tu compañero\nRecuerda que puedes cambiar de opinión.", "OK");
        }

        private void btnCalificar(object sender, EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("RankStudent", "No es posible calificar.\nEsta operación está en mantenimiento.\nDisculpe las molestias", "OK");
        }
    }
}