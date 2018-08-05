using System;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace GeraContrato.DB
{
    public class DBConnection
    {
        private static MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection Connection
        {
            get { return connection;  }
        }
        
        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "geracontrato";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SslMode=none";

            connection = new MySqlConnection(connectionString);            
        }

        public bool Open()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.ToString());                
            }
        }
    }
}
