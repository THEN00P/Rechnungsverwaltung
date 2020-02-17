using System;
using System.Data.OleDb;

namespace Datenbankverwaltung {
    public class DB {
        public OleDbConnection DbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./ProjektDB.accdb");

        private OleDbDataReader SqlRead(string query) {
            DbConnection.Open();

            OleDbDataReader reader = new OleDbCommand(query, DbConnection).ExecuteReader();

            return reader;
        }
    }
}
