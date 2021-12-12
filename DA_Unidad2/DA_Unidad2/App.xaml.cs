using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DA_Unidad2.DataBase;
using System.IO;
using DA_Unidad2.Model;

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

        private readonly Random _random = new Random();
        // Generates a random number within a range.      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public App()
        {
            InitializeComponent();


            /*
            RS_Usuarios User1_test = new RS_Usuarios(); User1_test.rs_akaEmail = "user1@utp.edu.co"; User1_test.rs_name = "Usuario Prueba 1"; User1_test.rs_pkey = "123"; Db.SaveUserModelAsync(User1_test); User1_test.rs_akaCenterId = "utp"; User1_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User2_test = new RS_Usuarios(); User2_test.rs_akaEmail = "user2@utp.edu.co"; User2_test.rs_name = "Usuario Prueba 2"; User2_test.rs_pkey = "123"; Db.SaveUserModelAsync(User2_test); User2_test.rs_akaCenterId = "utp"; User2_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User3_test = new RS_Usuarios(); User3_test.rs_akaEmail = "user3@utp.edu.co"; User3_test.rs_name = "Usuario Prueba 3"; User3_test.rs_pkey = "123"; Db.SaveUserModelAsync(User3_test); User3_test.rs_akaCenterId = "utp"; User3_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User4_test = new RS_Usuarios(); User4_test.rs_akaEmail = "user4@utp.edu.co"; User4_test.rs_name = "Usuario Prueba 4"; User4_test.rs_pkey = "123"; Db.SaveUserModelAsync(User4_test); User4_test.rs_akaCenterId = "utp"; User4_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User5_test = new RS_Usuarios(); User5_test.rs_akaEmail = "user5@utp.edu.co"; User5_test.rs_name = "Usuario Prueba 5"; User5_test.rs_pkey = "123"; Db.SaveUserModelAsync(User5_test); User5_test.rs_akaCenterId = "utp"; User5_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User6_test = new RS_Usuarios(); User6_test.rs_akaEmail = "user6@utp.edu.co"; User6_test.rs_name = "Usuario Prueba 6"; User6_test.rs_pkey = "123"; Db.SaveUserModelAsync(User6_test); User6_test.rs_akaCenterId = "utp"; User6_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User7_test = new RS_Usuarios(); User7_test.rs_akaEmail = "user7@utp.edu.co"; User7_test.rs_name = "Usuario Prueba 7"; User7_test.rs_pkey = "123"; Db.SaveUserModelAsync(User7_test); User7_test.rs_akaCenterId = "utp"; User7_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User8_test = new RS_Usuarios(); User8_test.rs_akaEmail = "user8@utp.edu.co"; User8_test.rs_name = "Usuario Prueba 8"; User8_test.rs_pkey = "123"; Db.SaveUserModelAsync(User8_test); User8_test.rs_akaCenterId = "utp"; User8_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User9_test = new RS_Usuarios(); User9_test.rs_akaEmail = "user9@utp.edu.co"; User9_test.rs_name = "Usuario Prueba 9"; User9_test.rs_pkey = "123"; Db.SaveUserModelAsync(User9_test); User9_test.rs_akaCenterId = "utp"; User9_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            RS_Usuarios User10_test = new RS_Usuarios(); User10_test.rs_akaEmail = "user10@utp.edu.co"; User10_test.rs_name = "Usuario Prueba 10"; User10_test.rs_pkey = "123"; Db.SaveUserModelAsync(User10_test); User10_test.rs_akaCenterId = "utp"; User10_test.rs_akaCenterName = "Universidad Tecnológica de Pereira";
            ScoreRecords ScoreUser1_test = new ScoreRecords(); ScoreUser1_test.rs_akaEmail = "user1@utp.edu.co"; ScoreUser1_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser1_test);
            ScoreRecords ScoreUser2_test = new ScoreRecords(); ScoreUser2_test.rs_akaEmail = "user2@utp.edu.co"; ScoreUser2_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser2_test);
            ScoreRecords ScoreUser3_test = new ScoreRecords(); ScoreUser3_test.rs_akaEmail = "user3@utp.edu.co"; ScoreUser3_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser3_test);
            ScoreRecords ScoreUser4_test = new ScoreRecords(); ScoreUser4_test.rs_akaEmail = "user4@utp.edu.co"; ScoreUser4_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser4_test);
            ScoreRecords ScoreUser5_test = new ScoreRecords(); ScoreUser5_test.rs_akaEmail = "user5@utp.edu.co"; ScoreUser5_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser5_test);
            ScoreRecords ScoreUser6_test = new ScoreRecords(); ScoreUser6_test.rs_akaEmail = "user6@utp.edu.co"; ScoreUser6_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser6_test);
            ScoreRecords ScoreUser7_test = new ScoreRecords(); ScoreUser7_test.rs_akaEmail = "user7@utp.edu.co"; ScoreUser7_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser7_test);
            ScoreRecords ScoreUser8_test = new ScoreRecords(); ScoreUser8_test.rs_akaEmail = "user8@utp.edu.co"; ScoreUser8_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser8_test);
            ScoreRecords ScoreUser9_test = new ScoreRecords(); ScoreUser9_test.rs_akaEmail = "user9@utp.edu.co"; ScoreUser9_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser9_test);
            ScoreRecords ScoreUser10_test = new ScoreRecords(); ScoreUser10_test.rs_akaEmail = "user10@utp.edu.co"; ScoreUser10_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser10_test);
            //Test user unilibre
            RS_Usuarios User1UL_test = new RS_Usuarios(); User1UL_test.rs_akaEmail = "user1@unilibre.edu.co"; User1UL_test.rs_name = "Usuario Prueba 1"; User1UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User1UL_test); User1UL_test.rs_akaCenterId = "utp"; User1UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User2UL_test = new RS_Usuarios(); User2UL_test.rs_akaEmail = "user2@unilibre.edu.co"; User2UL_test.rs_name = "Usuario Prueba 2"; User2UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User2UL_test); User2UL_test.rs_akaCenterId = "utp"; User2UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User3UL_test = new RS_Usuarios(); User3UL_test.rs_akaEmail = "user3@unilibre.edu.co"; User3UL_test.rs_name = "Usuario Prueba 3"; User3UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User3UL_test); User3UL_test.rs_akaCenterId = "utp"; User3UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User4UL_test = new RS_Usuarios(); User4UL_test.rs_akaEmail = "user4@unilibre.edu.co"; User4UL_test.rs_name = "Usuario Prueba 4"; User4UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User4UL_test); User4UL_test.rs_akaCenterId = "utp"; User4UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User5UL_test = new RS_Usuarios(); User5UL_test.rs_akaEmail = "user5@unilibre.edu.co"; User5UL_test.rs_name = "Usuario Prueba 5"; User5UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User5UL_test); User5UL_test.rs_akaCenterId = "utp"; User5UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User6UL_test = new RS_Usuarios(); User6UL_test.rs_akaEmail = "user6@unilibre.edu.co"; User6UL_test.rs_name = "Usuario Prueba 6"; User6UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User6UL_test); User6UL_test.rs_akaCenterId = "utp"; User6UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User7UL_test = new RS_Usuarios(); User7UL_test.rs_akaEmail = "user7@unilibre.edu.co"; User7UL_test.rs_name = "Usuario Prueba 7"; User7UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User7UL_test); User7UL_test.rs_akaCenterId = "utp"; User7UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User8UL_test = new RS_Usuarios(); User8UL_test.rs_akaEmail = "user8@unilibre.edu.co"; User8UL_test.rs_name = "Usuario Prueba 8"; User8UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User8UL_test); User8UL_test.rs_akaCenterId = "utp"; User8UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User9UL_test = new RS_Usuarios(); User9UL_test.rs_akaEmail = "user9@unilibre.edu.co"; User9UL_test.rs_name = "Usuario Prueba 9"; User9UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User9UL_test); User9UL_test.rs_akaCenterId = "utp"; User9UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            RS_Usuarios User10UL_test = new RS_Usuarios(); User10UL_test.rs_akaEmail = "user10@unilibre.edu.co"; User10UL_test.rs_name = "Usuario Prueba 10"; User10UL_test.rs_pkey = "123"; Db.SaveUserModelAsync(User10UL_test); User10UL_test.rs_akaCenterId = "utp"; User10UL_test.rs_akaCenterName = "Universidad Libre Pereira";
            ScoreRecords ScoreUser1UL_test = new ScoreRecords(); ScoreUser1UL_test.rs_akaEmail = "user1@unilibre.edu.co"; ScoreUser1UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser1UL_test);
            ScoreRecords ScoreUser2UL_test = new ScoreRecords(); ScoreUser2UL_test.rs_akaEmail = "user2@unilibre.edu.co"; ScoreUser2UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser2UL_test);
            ScoreRecords ScoreUser3UL_test = new ScoreRecords(); ScoreUser3UL_test.rs_akaEmail = "user3@unilibre.edu.co"; ScoreUser3UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser3UL_test);
            ScoreRecords ScoreUser4UL_test = new ScoreRecords(); ScoreUser4UL_test.rs_akaEmail = "user4@unilibre.edu.co"; ScoreUser4UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser4UL_test);
            ScoreRecords ScoreUser5UL_test = new ScoreRecords(); ScoreUser5UL_test.rs_akaEmail = "user5@unilibre.edu.co"; ScoreUser5UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser5UL_test);
            ScoreRecords ScoreUser6UL_test = new ScoreRecords(); ScoreUser6UL_test.rs_akaEmail = "user6@unilibre.edu.co"; ScoreUser6UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser6UL_test);
            ScoreRecords ScoreUser7UL_test = new ScoreRecords(); ScoreUser7UL_test.rs_akaEmail = "user7@unilibre.edu.co"; ScoreUser7UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser7UL_test);
            ScoreRecords ScoreUser8UL_test = new ScoreRecords(); ScoreUser8UL_test.rs_akaEmail = "user8@unilibre.edu.co"; ScoreUser8UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser8UL_test);
            ScoreRecords ScoreUser9UL_test = new ScoreRecords(); ScoreUser9UL_test.rs_akaEmail = "user9@unilibre.edu.co"; ScoreUser9UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser9UL_test);
            ScoreRecords ScoreUser10UL_test = new ScoreRecords(); ScoreUser10UL_test.rs_akaEmail = "user10@unilibre.edu.co"; ScoreUser10UL_test.rs_score = RandomNumber(0, 1000); Db.SaveScoreAsync(ScoreUser10UL_test);
            */
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
