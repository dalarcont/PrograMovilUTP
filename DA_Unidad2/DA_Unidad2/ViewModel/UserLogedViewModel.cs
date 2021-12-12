using DA_Unidad2.Model;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using System.Linq;

namespace DA_Unidad2.ViewModel
{
    class UserLogedViewModel:BaseViewModel
    {
        #region ATTR
        private string email;
        private string pkey;
        private string name;
        private string center;
        private string centerId;
        private string semestre;
        private string semestreActual;
        private string semestreSiguiente;
        private int scoreActual = 0;
        private string scorecolor;
        #endregion

        #region PROP
        public string Email { get { return this.email; } set { SetValue(ref this.email, value); } }
        public string Pkey { get { return this.pkey; } set { SetValue(ref this.pkey, value); } }
        public string Name { get { return this.name; } set { SetValue(ref this.name, value); } }
        public string Center { get { return this.center; } set { SetValue(ref this.center, value); } }
        public string CenterId { get { return this.centerId; } set { SetValue(ref this.centerId, value); } }
        public string Semestre { get => semestre; set => semestre = value; }
        public string SemestreActual { get => semestreActual; set => semestreActual = value; }
        public string SemestreSiguiente { get => semestreSiguiente; set => semestreSiguiente = value; }
        public int ScoreActual { get => scoreActual; set => scoreActual = value; }
        public string Scorecolor { get => scorecolor; set => scorecolor = value; }
        #endregion

        #region MyRegion
        public void SemestreFinalizado()
        {
            DateTime Fecha = DateTime.Now;
            var result = DateTime.Parse(Fecha.ToString()).Year;
            int year = result;
            if (DateTime.Parse(Fecha.ToString()).Month <= 6)
            {
                //Significa que el último semestre trabajado fue el segundo del año anterior
                year += 1;
                this.Semestre = string.Concat(year.ToString(), "-2");
            }
            else
            {
                //Significa que el último semestre trabajado fue el primero del año actual
                this.Semestre = string.Concat(year.ToString(),"-1"); 
            }
        }
        public void SemestreEnCurso()
        {
            DateTime Fecha = DateTime.Now;
            var result = DateTime.Parse(Fecha.ToString()).Year;
            int year = result;
            if (DateTime.Parse(Fecha.ToString()).Month <= 6)
            {
                //Significa que el semestre en curso es el primero del año
                this.SemestreActual = string.Concat(year.ToString(), "-1");
            }
            else
            {
                //Significa que el semestre en curso es el ultimo del año
                this.SemestreActual = string.Concat(year.ToString(), "-2");
            }
        }
        public void SemestreProximo()
        {
            DateTime Fecha = DateTime.Now;
            var result = DateTime.Parse(Fecha.ToString()).Year;
            int year = result;
            if (DateTime.Parse(Fecha.ToString()).Month <= 6)
            {
                //Significa que el semestre siguiente es el último
                this.SemestreSiguiente = string.Concat(year.ToString(), "-2");
            }
            else
            {
                //Significa que el semestre en curso es el primero del próximo año
                this.SemestreSiguiente = string.Concat((year+1).ToString(), "-2");
            }
        }
        #endregion
        public UserLogedViewModel(string usr, string pkey)
        {
            //Get user data
            RS_Usuarios LogedUser = new RS_Usuarios();
            LogedUser = App.Db.GetUserModel(usr, pkey).Result;
            this.Name = LogedUser.rs_name;
            this.Email = LogedUser.rs_akaEmail;
            this.CenterId = LogedUser.rs_akaCenterId;
            this.Center = LogedUser.rs_akaCenterName;
            SemestreFinalizado();
            SemestreEnCurso();
            SemestreProximo();

            //Get score
            ScoreRecords Score = new ScoreRecords();
            Score = App.Db.GetUserScore(usr).Result;
            this.ScoreActual = Score.rs_score;
            //Text color for score 
            if(this.ScoreActual <= 250) {
                this.Scorecolor = "#FF0000";
            }
            else if(this.ScoreActual <= 500)
            {
                this.Scorecolor = "#FF8C02";
            }
            else
            {
                if(this.ScoreActual <= 750)
                {
                    this.Scorecolor = "#00EBEB";
                }
                else
                {
                    this.Scorecolor = "#1CEB00";
                }
            }
        }
    }
}
