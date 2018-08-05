namespace GeraContrato.Entities
{
    public class DataModelItem
    {
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

        private DataModel _dataModel;

        public DataModel DataModel
        {
            get
            {
                return _dataModel;
            }
            set
            {
                if(_dataModel != value)
                {
                    _dataModel = value;
                }
            }
        }

    }
}
