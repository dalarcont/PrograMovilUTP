using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DA_Unidad2.DataBase;
using System.IO;

namespace DA_Unidad2
{
    public partial class App : Application
    {
        static DataBaseEngine database;
        public static DataBaseEngine Db
        {
            get
            {
                if (database == null)
                {
                    database = new DataBaseEngine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RS.db"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DA_Unidad2.MainPage());
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
