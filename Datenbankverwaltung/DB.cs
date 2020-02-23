using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.OleDb;

namespace Datenbankverwaltung {
    static public class DB {
        public static OleDbConnection DbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./rechnung.accdb");

        public static bool validLogin(string username, string passwort)
        {
            if (username == "" || passwort == "")
                return false;

            var res = SqlRead("SELECT m_loginpw FROM mitarbeiter WHERE m_loginname = '" + username + "'");

            if (res.Count < 1)
                return false;

            return res[0]["m_loginpw"].ToString() == passwort;
        }

        public static List<Dictionary<string, object>> SqlRead(string query)
        {
            //fehler falls es sich nicht um einen SELECT befehl handelt
            if (!query.ToUpper().StartsWith("SELECT"))
                throw new Exception("SQL query enthielt keinen SELECT befehl.");

            List<Dictionary<string, object>> rückgabeWert = new List<Dictionary<string, object>>();

            //Nimmt den text nach SELECT und vor FROM und ignoriert dabei groß / kleinschreibung
            string queryFix = query.Substring(7, query.ToUpper().IndexOf(" FROM ") - 7);

            //Liste der Abzufragenden Zeilen
            string[] querys = queryFix.Split(',');

            //formatiert die abzufragenden zeilen und weist alias zu
            for (int i = 0; i < querys.Length; i++)
            {
                if (querys[i].ToUpper().IndexOf(" AS ") > 0) querys[i] = querys[i].Substring(querys[i].ToUpper().IndexOf(" AS ") + 4, querys[i].Length - (querys[i].ToUpper().IndexOf(" AS ") + 4));
                querys[i] = querys[i].Replace(" ", "");
            }

            DbConnection.Open();

            OleDbDataReader reader = new OleDbCommand(query, DbConnection).ExecuteReader();

            while(reader.Read())
            {
                Dictionary<string, object> obj = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    obj[querys[i]] = reader[i];
                }

                rückgabeWert.Add(obj);
            }

            DbConnection.Close();

            return rückgabeWert;
        }

        public static int SqlWrite(string query)
        {
            DbConnection.Open();

            int res = new OleDbCommand(query, DbConnection).ExecuteNonQuery();

            DbConnection.Close();

            return res;
        }
    }
}
