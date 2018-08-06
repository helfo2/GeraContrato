using GeraContrato.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GeraContrato.Models.DataModelItem
{
    public class DataModelItemDAO
    {
        public DataModelItemDAO()
        {
            _db = new DBConnection();
        }

        #region DB Connection

        private DBConnection _db;

        #endregion

        #region IBasicCommands members

        public void Insert(DataModelItemDTO dto)
        {
            try
            {
                _db.Connection.Open();

                string sql = "INSERT INTO data_model (id, name) VALUES (@id, @name)";

                MySqlCommand comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", dto.Id);
                comm.Parameters.AddWithValue("@name", dto.Name);
                comm.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                _db.Close();
            }

        }

        public void Delete(DataModelItemDAO obj)
        {
            throw new System.NotImplementedException();
        }


        public List<DataModelItemDAO> Select(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<DataModelItemDAO> Select(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<DataModelItemDAO> SelectAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(DataModelItemDAO obj)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
