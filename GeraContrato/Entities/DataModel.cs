using GeraContrato.Models.DataModel;

namespace GeraContrato.Entities
{
    public class DataModel
    {
        #region Data access members

        private DataModelDAO mDataModel;
        public DataModelDTO DataModelEntity;

        #endregion

        #region Constructor

        public DataModel()
        {
            mDataModel = new DataModelDAO();
            DataModelEntity = new DataModelDTO();
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

        private void GetDTO(DataModelDTO dto)
        {
            
        }

        private void SetDTO()
        {
            DataModelEntity = new DataModelDTO
            {
                Id = null,
                Name = Name
            };           
        }

        public void NewDataModel()
        {
            SetDTO();
            mDataModel.Insert(DataModelEntity);
        }

        #endregion
    }
}
