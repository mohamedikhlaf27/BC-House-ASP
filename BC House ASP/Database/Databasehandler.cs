using System;
using System.Data;
using System.Data.SqlClient;

namespace BC_House_ASP.Database
{
    public class Databasehandler
    {
        /// <summary>
        /// connectie met de database
        /// </summary>
        public SqlConnectionStringBuilder builder { get; private set; }
        public SqlConnection con { get; private set; }
        public DataTable table { get; private set; }
        public SqlCommand cmd;
        public Databasehandler()
        {
            builder = new SqlConnectionStringBuilder();

            builder.DataSource = "mssql.fhict.local";
            builder.UserID = "dbi440096_bchouse";
            builder.Password = "waalwijk";
            builder.InitialCatalog = "dbi440096_bchouse";

            con = new SqlConnection(builder.ConnectionString);
        }

        public bool TestConnection()
        {
            bool open = false;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception)
            {
                return false;
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    open = true;
                }

                con.Close();
            }

            if (!open)
            {
                return false;
            }
            return open;
        }

        public void OpenConnectionToDB()
        {
            con.Open();
        }

        public void CloseConnectionToDB()
        {
            con.Close();
        }

        public SqlConnection GetCon()
        {
            return con;
        }

        public void ClearTable()
        {
            table.Clear();
        }

        public void AddTable()
        {
            table = new DataTable();
        }

    }
}

