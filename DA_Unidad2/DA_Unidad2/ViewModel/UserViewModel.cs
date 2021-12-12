using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DA_Unidad2.Model;
using GalaSoft.MvvmLight.Command;

using Xamarin.Forms;
namespace DA_Unidad2.ViewModel
{
    class UserViewModel:BaseViewModel
    {
        #region ATTR
        private string email;
        private string pkey;
        private string name;
        private string center;
        private string centerId;
        #endregion

        #region PROP
        public string Email { get { return this.email; } set { SetValue(ref this.email, value); } }
        public string Pkey { get { return this.pkey; } set { SetValue(ref this.pkey, value); } }
        public string Name { get { return this.name; } set { SetValue(ref this.name, value); } }
        public string Center { get { return this.center; } set { SetValue(ref this.center, value); } }
        public string CenterId { get { return this.centerId; } set { SetValue(ref this.centerId, value); } }
        #endregion

        #region AUXMTHDS
        public void akaCenter()
        {
            //Try to know what is the aka center where user belongs
            char delim = '@';
            char delim2 = '.';
            string[] vals1 = Email.Split(delim);
            string[] vals2 = vals1[1].Split(delim2);
            this.CenterId = vals2[0].ToUpper();
            switch (vals2[0])
            {
                case "utp":
                    this.Center = "Universidad Tecnológica de Pereira";
                break;

                case "unilibre":
                    this.Center = "Universidad Libre Pereira";
                break;

                default:
                    this.Center = "Otra universidad";
                    break;
            }
        }

        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        #endregion

        #region CMDS
        public ICommand SignupCMD
        {
            get
            {
                return new RelayCommand(SignupExecution);
            }
            set { }
        }
        #endregion

        #region MTHDS
        public async void SignupExecution()
        {
            var newUser = new RS_Usuarios();
            newUser.rs_akaEmail = Email;
            newUser.rs_pkey = Pkey;
            newUser.rs_name = Name;
            //for akacenter name and id use the following method
            akaCenter();
            newUser.rs_akaCenterId = CenterId;
            newUser.rs_akaCenterName = Center;
            await App.Db.SaveUserModelAsync(newUser);
            ScoreRecords UserScoreDefault = new ScoreRecords();
            UserScoreDefault.rs_score = RandomNumber(0,1000);
            UserScoreDefault.rs_akaEmail = Email;
            await App.Db.SaveScoreAsync(UserScoreDefault);
            await Application.Current.MainPage.DisplayAlert("RankStudent - Registro","Bienvenido: \n" + Name + "\nRegistro exitoso en RankStudent para la institución:\n" + Center + "", "OK");
            await Application.Current.MainPage.Navigation.PopAsync();

        }
        #endregion

    }
}
