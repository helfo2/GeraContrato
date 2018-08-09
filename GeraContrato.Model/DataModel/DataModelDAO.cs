using GeraContrato.DB;
using GeraContrato.DB.Utility;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using GeraContrato.Models.DataModelItem;

namespace GeraContrato.Models.DataModel
{
    public class DataModelDAO : IBasicCommands<DataModelDTO>
    {
        public DataModelDAO()
        {
            if(_db == null)
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

        public void Delete(DataModelDTO dto)
        {
            try
            {
                _db.Connection.Open();

                if (dto.Id != -1)
                {
                    string sql = "DELETE FROM data_model WHERE id = @id";

                    MySqlCommand comm = _db.Connection.CreateCommand();
                    comm.CommandText = sql;
                    comm.Parameters.AddWithValue("@id", dto.Id);

                    comm.ExecuteNonQuery();
                }
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

        public DataModelDTO Select(int id)
        {
            try
            {
                _db.Connection.Open();

                string sql = "SELECT * FROM data_model WHERE id = @id";

                MySqlCommand comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = comm.ExecuteReader();
                reader.Read();

                DataModelDTO dto = new DataModelDTO
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Name = reader["name"].ToString()
                };

                return dto;
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

        public DataTable SelectAllIntoDataTable()
        {
            try
            {
                _db.Connection.Open();

                string sql = "SELECT * FROM data_model";

                MySqlCommand comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;

                MySqlDataReader reader = comm.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("id", typeof(string));
                dt.Columns.Add("name", typeof(string));
                dt.Load(reader);
                
                return dt;
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

        public DataModelDTO GetInsertedDataModel()
        {
            try
            {
                _db.Connection.Open();

                string sql = "SELECT * FROM data_model WHERE id IN (SELECT MAX(id) FROM data_model)";

                MySqlCommand comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;

                MySqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                
                DataModelDTO dto = new DataModelDTO
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Name = reader["name"].ToString()
                };

                return dto;
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

        public List<DataModelItemDTO> SelectDataItems(DataModelDTO dto)
        {
            try
            {
                _db.Connection.Open();

                string sql = "SELECT * FROM data_model_item WHERE id_data_model = @id";

                MySqlCommand comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", dto.Id);
                MySqlDataReader reader = comm.ExecuteReader();
                
                List<DataModelItemDTO> items = new List<DataModelItemDTO>();

                int id;
                string name;

                while(reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                    name = reader["name"].ToString();

                    DataModelItemDTO itemdto = new DataModelItemDTO
                    {
                        Id = id,
                        Name = name
                    };

                    items.Add(itemdto);
                }

                return items;
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

        public void FullUpdate(DataModelDTO dto, List<DataModelItemDTO> items)
        {
            try
            {
                _db.Connection.Open();
                
                string sql = "UPDATE data_model SET name = @name WHERE id = @id";

                MySqlCommand comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", dto.Id);
                comm.Parameters.AddWithValue("@name", dto.Name);

                comm.ExecuteNonQuery();

                sql = "DELETE FROM data_model_item WHERE id_data_model = @id";
                comm = _db.Connection.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", dto.Id);
                comm.ExecuteNonQuery();

                foreach (DataModelItemDTO item in items)
                {
                    sql = "INSERT INTO data_model_item (id, name, id_data_model) VALUES (@id, @name, @id_data_model)";
                    comm = _db.Connection.CreateCommand();
                    comm.CommandText = sql;
                    comm.Parameters.AddWithValue("@id", null);
                    comm.Parameters.AddWithValue("@name", item.Name);
                    comm.Parameters.AddWithValue("@id_data_model", item.DataModel.Id);
                    comm.ExecuteNonQuery();
                }                
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

        public void Update(DataModelDTO obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
