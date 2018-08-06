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

        public List<DataModelDTO> SelectAll()
        {
            try
            {
                _db.Connection.Open();

                string sql = "SELECT * FROM data_model";

                MySqlCommand comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;
                
                MySqlDataReader reader = comm.ExecuteReader();

                List<DataModelDTO> found = new List<DataModelDTO>();
                DataModelDTO dto;
                int? id;
                string name;
                while (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                    name = reader["name"].ToString();

                    dto = new DataModelDTO
                    {
                        Id = id,
                        Name = name
                    };

                    found.Add(dto);
                }

                return found;
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

        public List<DataModelDTO> Select(string name)
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
