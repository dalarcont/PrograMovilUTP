using DA_Unidad2.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
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
        }

        #region CRUD
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
        #endregion
    }


}
