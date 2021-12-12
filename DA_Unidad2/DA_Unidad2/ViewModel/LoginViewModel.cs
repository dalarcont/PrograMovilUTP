using DA_Unidad2.Model;
using DA_Unidad2.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DA_Unidad2.ViewModel
{
     class LoginViewModel : BaseViewModel
    {
        #region ATTR
        public string email;
        public string password;
        #endregion

        #region PROP
        public string emailTxt
        {
            get
            {
                return this.email;
            }
            set
            {
                SetValue(ref this.email, value);
            }
        }

        public string passwordTxt
        {
            get
            {
                return this.password;
            }
            set
            {
                SetValue(ref this.password, value);
            }
        }
        #endregion

        #region CMDS
        public ICommand LoginCMD
        {
            get
            {
                return new RelayCommand(LoginExec);
            }
            set { }
        }
        #endregion

        #region MTHDS
        public async void LoginExec()
        {
            List<RS_Usuarios> ListaUsuarios = App.Db.ValidateUserModel(emailTxt, passwordTxt).Result;
            RS_Usuarios User = App.Db.GetUserModel(emailTxt, passwordTxt).Result;

            if(ListaUsuarios.Count > 0)
            {
                await Application.Current.MainPage.DisplayAlert("RankStudent", "Bienvenido " + User.rs_name + "", "OK");
                //Show new page content
                await Application.Current.MainPage.Navigation.PushAsync(new Landing(User.rs_akaEmail, User.rs_pkey));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("RankStudent", "No se puede completar el acceso.\nPosiblmente usuario no existe o base de datos no está disponible", "OK");
            }
        }
        #endregion
    }
}
