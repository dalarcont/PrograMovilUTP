using DA_Unidad2.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DA_Unidad2.DataBase
{
    public class DataBaseEngine
    {
        readonly SQLiteAsyncConnection _database;
        
        public DataBaseEngine(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<RS_Usuarios>().Wait();
            _database.CreateTableAsync<ScoreRecords>().Wait();
        }

        #region CRUD

        //Signup and login frame
        public Task<List<RS_Usuarios>> ValidateUserModel(string usr, string pw)
        {
            return _database.QueryAsync<RS_Usuarios>("SELECT * FROM RS_Usuarios WHERE rs_akaEmail = '" + usr + "' AND rs_pkey = '" + pw + "' ");
        }

        public Task<RS_Usuarios> GetUserModel(string usr, string pw)
        {
            return _database.Table<RS_Usuarios>().Where(i => i.rs_akaEmail == usr && i.rs_pkey == pw).FirstOrDefaultAsync();
        }


        public Task<int> SaveUserModelAsync(RS_Usuarios usermodel)
        {
            return _database.InsertAsync(usermodel);
        }

        //Score frame
        public Task<List<ScoreRecords>> ValidateScoreRecord(string usr)
        {
            return _database.QueryAsync<ScoreRecords>("SELECT * FROM ScoreRecords WHERE rs_akaEmail = '" + usr + "'");
        }

        public Task<ScoreRecords> GetUserScore(string usr)
        {
            return _database.Table<ScoreRecords>().Where(i => i.rs_akaEmail == usr).FirstOrDefaultAsync();
        }


        //Use the following method inside the 
        public Task<int> SaveScoreAsync(ScoreRecords Record)
        {
            return _database.InsertAsync(Record);
        }

        #endregion
    }


}
