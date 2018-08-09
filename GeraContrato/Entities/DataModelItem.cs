using GeraContrato.Models.DataModelItem;
using System.Collections.Generic;

namespace GeraContrato.Entities
{
    public class DataModelItem
    {
        #region Data access members

        private DataModelItemDAO mDataModelItem;
        public DataModelItemDTO DataModelItemEntity;

        #endregion

        #region Constructor

        public DataModelItem()
        {
            mDataModelItem = new DataModelItemDAO();
            DataModelItemEntity = new DataModelItemDTO();
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
                if (_id != value)
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

        private DataModel _currentDataModel;

        public DataModel CurrentDataModel
        {
            get
            {
                return _currentDataModel;
            }
            set
            {
                if(_currentDataModel != value)
                {
                    _currentDataModel = value;
                }
            }
        }

        #endregion

        #region Access data members 

        public DataModelItemDTO GetDTO()
        {
            return DataModelItemEntity;
        }

        public void SetDTO()
        {
            DataModelItemEntity = new DataModelItemDTO
            {
                Id = null,
                Name = Name,
                DataModel = CurrentDataModel.GetDTO()
            };
        }

        public void NewDataModelItem(DataModelItemDTO dto)
        {
            mDataModelItem.Insert(dto);
        }

        #endregion
    }
}
