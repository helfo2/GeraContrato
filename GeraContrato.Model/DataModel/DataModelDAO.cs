using GeraContrato.DB;
using GeraContrato.DB.Utility;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace GeraContrato.Models.DataModel
{
    public class DataModelDAO : IBasicCommands<DataModelDTO>
    {
        public DataModelDAO()
        {
            _db = new DBConnection();
        }
     
        #region DB Connection

        private DBConnection _db;        

        #endregion

        #region IBasicCommands members

        public void Insert(DataModelDTO dto)
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
