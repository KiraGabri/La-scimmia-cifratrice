using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace UsaSeriale
{
    public static class GestioneMySql
    {

        public static string StringaConnessione = "DataSource=localhost; Database=monkey; userid=monkey; password=controller;";
        public static MySqlConnection Connessione = new MySqlConnection(StringaConnessione);

        public static bool ApriConnessione()
        {
            try
            {
                if (Connessione.State != ConnectionState.Open)
                {
                    Connessione.ConnectionString = GestioneMySql.StringaConnessione;
                    Connessione.Open();
                }
                return true;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public static bool ChiudiConnessione()
        {
            try
            {
                if (Connessione.State != System.Data.ConnectionState.Closed)
                {
                    Connessione.Close();
                }
                return true;
            }
            catch (Exception f)
            {
                return false;
            }
        }


        public static MySqlDataReader RequestQuery(string sql)
        {
            try
            {
                ApriConnessione();
                MySqlCommand cmd = new MySqlCommand(sql, Connessione);
                MySqlDataReader rdr = cmd.ExecuteReader();
                return rdr;

            }
            catch (Exception f)
            {
                ChiudiConnessione();
                return null;
            }

        }

        public static bool InsertValues(string sql)
        {
            try
            {
                ApriConnessione();
                MySqlCommand cmd = new MySqlCommand(sql, GestioneMySql.Connessione);
                cmd.ExecuteNonQuery();
                ChiudiConnessione();
                return true;
            }
            catch (Exception f)
            {

                ChiudiConnessione();
                return false;
            }

        }
    }
}
