using GeraContrato.Models.DataModel;
using GeraContrato.Models.DataModelItem;
using System;
using System.Collections.Generic;
using System.Data;

namespace GeraContrato.Entities
{
    public class DataModel
    {
        #region Data access members

        private DataModelDAO mDataModel;
        private List<DataModelItemDTO> dataModelItems;

        public DataModelDTO DataModelEntity;

        #endregion

        #region Constructor

        public DataModel()
        {
            mDataModel = new DataModelDAO();
            DataModelEntity = new DataModelDTO();
            dataModelItems = new List<DataModelItemDTO>();
        }

        #endregion

        #region Properties

        private int? _id;
        
        public int? Id
        {
            get
            {
                return _id;
            }
            set
            {
                if(_id != value)
                {
                    _id = value;
                }
            }
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }

        #endregion

        #region Access data methods

        public DataModelDTO GetDTO()
        {
            return DataModelEntity;
        }

        private void SetDTO()
        {
            DataModelEntity = new DataModelDTO
            {
                Id = null,
                Name = Name
            };           
        }

        public void SetEntityDTO(int id)
        {
            DataModelEntity = new DataModelDTO
            {
                Id = id,
                Name = Name
            };
        }

        public void NewDataModel()
        {
            SetDTO();
            mDataModel.Insert(DataModelEntity);
        }

        public List<DataModelDTO> FindAll()
        {
            return mDataModel.SelectAll();
        }

        public DataTable LoadDataModels()
        {
            return mDataModel.SelectAllIntoDataTable();
        }

        public Tuple<int?, string> Find(int id)
        {
            DataModelEntity = mDataModel.Select(id);
            
            return new Tuple<int?, string>(DataModelEntity.Id, DataModelEntity.Name);
        }

        public DataModelDTO GetNew()
        {
            return mDataModel.GetInsertedDataModel();
        }

        public void Delete()
        {
            mDataModel.Delete(DataModelEntity);
        }

        public void Update(List<string> dataItems)
        {
            dataModelItems = new List<DataModelItemDTO>();

            foreach (var item in dataItems)
            {
                dataModelItems.Add(new DataModelItemDTO { Id = null, Name = item });
            }

            dataModelItems.ForEach(i => i.DataModel = Convert_DataModelToDTO(new DataModel { Id = DataModelEntity.Id, Name = DataModelEntity.Name }));
            mDataModel.FullUpdate(DataModelEntity, dataModelItems);
        }

        public List<DataModelItemDTO> SelectDataItems()
        {
            return mDataModel.SelectDataItems(DataModelEntity);
        }


        public DataModel Convert_DTOToDataModel(DataModelDTO dto)
        {
            return new DataModel()
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }

        public DataModelDTO Convert_DataModelToDTO(DataModel dataModel)
        {
            return new DataModelDTO()
            {
                Id = dataModel.Id,
                Name = dataModel.Name
            };
        }

        #endregion
    }
}
