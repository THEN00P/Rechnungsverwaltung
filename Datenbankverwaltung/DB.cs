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

        public class Artikel 

        public class Rechnung {
            public readonly int RechNr;
            public int FirmenNummer;
            public DateTime Datum;
            public string Firmenname;
            public string zH;
            public string Straße;
            public string Tel;
            public int PLZ;
            public string Ort;
            public string Fax;

            public Rechnung(int RechNr) {
                this.RechNr = RechNr;
            }

            static Rechnung GetByNr(int rnr) {
                DB.SqlRead("");

                Rechnung rechnung = new Rechnung();
                return rechnung;
            }
        }
    }
}
