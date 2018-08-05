using GeraContrato.DB;
using GeraContrato.DB.Utility;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GeraContrato.Models.DataModel
{
    public sealed class DataModelDAO : IBasicCommands<DataModelDTO>
    {
        #region DAO Singleton Instance

        private static DataModelDAO instance = new DataModelDAO();

        private DataModelDAO()
        {

        }

        public static DataModelDAO Instance
        {
            get
            {
                lock (instance)
                {
                    if (instance == null)
                    {
                        instance = new DataModelDAO();
                    }
                }

                return instance;
            }
        }

        #endregion

        #region DB Connection

        private DBConnection conn;

        #endregion

        #region IBasicCommands members

        public void Insert(DataModelDTO dto)
        {
            using (conn = new DBConnection())
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO data_model (id, name) VALUES (@id, @name)";

                    MySqlCommand comm = conn.CreateCommand();

                }
                catch (MySqlException ex)
                {

                }
            }
        }

        public void Delete(DataModelDTO obj)
        {
            throw new System.NotImplementedException();
        }
        

        public List<DataModelDTO> Select(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<DataModelDTO> Select(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<DataModelDTO> SelectAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(DataModelDTO obj)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
