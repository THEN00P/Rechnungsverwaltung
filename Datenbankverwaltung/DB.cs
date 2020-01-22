using System;
using System.Data.OleDb;

namespace Datenbankverwaltung {
    public class DB {
        public OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./ProjektDB.accdb");
    }
}
