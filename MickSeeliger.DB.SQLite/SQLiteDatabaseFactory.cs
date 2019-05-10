using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MickSeeliger.DB.SQLite
{
    public class SQLiteDatabaseFactory : IDatabaseFactory
    {
        #region Private Variables
        private string connectionString;
        #endregion

        #region Constructors
        public SQLiteDatabaseFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }
        #endregion

        #region Public Methods
        public IDbConnection CreateConnection()
        {
            throw new NotImplementedException();
            // Todo: return new SQLiteConnection(connectionString);
        } 
        #endregion
    }
}
